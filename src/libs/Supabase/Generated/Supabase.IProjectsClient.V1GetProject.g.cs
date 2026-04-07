#nullable enable

namespace Supabase
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Gets a specific project that belongs to the authenticated user
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.V1ProjectWithDatabaseResponse> V1GetProjectAsync(
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}