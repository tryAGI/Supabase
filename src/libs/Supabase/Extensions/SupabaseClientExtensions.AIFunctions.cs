using Microsoft.Extensions.AI;

namespace tryAGI.Supabase;

/// <summary>
/// Extension methods for creating AI functions from the Supabase client.
/// </summary>
public static partial class SupabaseClientExtensions
{
    /// <summary>
    /// Returns a list of AI functions that can be used with any MEAI-compatible AI provider.
    /// </summary>
    /// <param name="client">The Supabase client instance.</param>
    /// <returns>A list of AI functions.</returns>
    public static IList<AIFunction> AsTools(this global::Supabase.SupabaseClient client)
    {
        return
        [
            AIFunctionFactory.Create(
                async (CancellationToken cancellationToken) =>
                {
                    var response = await client.Projects.V1ListAllProjectsAsync(
                        cancellationToken).ConfigureAwait(false);

                    return response;
                },
                "ListProjects",
                "Lists all Supabase projects belonging to the authenticated user."),

            AIFunctionFactory.Create(
                async (string projectRef, CancellationToken cancellationToken) =>
                {
                    var response = await client.Projects.V1GetProjectAsync(
                        @ref: projectRef,
                        cancellationToken).ConfigureAwait(false);

                    return response;
                },
                "GetProject",
                "Gets details for a specific Supabase project by its reference ID."),

            AIFunctionFactory.Create(
                async (CancellationToken cancellationToken) =>
                {
                    var response = await client.Organizations.V1ListAllOrganizationsAsync(
                        cancellationToken).ConfigureAwait(false);

                    return response;
                },
                "ListOrganizations",
                "Lists all organizations the authenticated user belongs to."),

            AIFunctionFactory.Create(
                async (string projectRef, CancellationToken cancellationToken) =>
                {
                    var response = await client.EdgeFunctions.V1ListAllFunctionsAsync(
                        @ref: projectRef,
                        cancellationToken).ConfigureAwait(false);

                    return response;
                },
                "ListEdgeFunctions",
                "Lists all Edge Functions deployed to a specific Supabase project."),
        ];
    }
}
