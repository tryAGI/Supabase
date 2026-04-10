#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Supabase
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create a project
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.V1ProjectResponse> V1CreateAProjectAsync(

            global::Supabase.V1CreateProjectBody request,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a project
        /// </summary>
        /// <param name="dbPass">
        /// Database password
        /// </param>
        /// <param name="name">
        /// Name of your project
        /// </param>
        /// <param name="organizationSlug">
        /// Organization slug<br/>
        /// Example: tsrqponmlkjihgfedcba
        /// </param>
        /// <param name="regionSelection">
        /// Region selection. Only one of region or region_selection can be specified.
        /// </param>
        /// <param name="desiredInstanceSize">
        /// Desired instance size. Omit this field to always default to the smallest possible size.
        /// </param>
        /// <param name="templateUrl">
        /// Template URL used to create the project from the CLI.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.V1ProjectResponse> V1CreateAProjectAsync(
            string dbPass,
            string name,
            string organizationSlug,
            global::Supabase.RegionSelection? regionSelection = default,
            global::Supabase.V1CreateProjectBodyDesiredInstanceSize? desiredInstanceSize = default,
            string? templateUrl = default,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}