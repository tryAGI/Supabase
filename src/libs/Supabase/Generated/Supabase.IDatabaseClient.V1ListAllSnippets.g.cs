#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// Lists SQL snippets for the logged in user
        /// </summary>
        /// <param name="projectRef">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="limit"></param>
        /// <param name="sortBy"></param>
        /// <param name="sortOrder"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.SnippetList> V1ListAllSnippetsAsync(
            string? projectRef = default,
            string? cursor = default,
            string? limit = default,
            global::Supabase.V1ListAllSnippetsSortBy? sortBy = default,
            global::Supabase.V1ListAllSnippetsSortOrder? sortOrder = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}