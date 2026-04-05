#nullable enable

namespace Supabase
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Lists available restore versions for the given project
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.GetProjectAvailableRestoreVersionsResponse> V1ListAvailableRestoreVersionsAsync(
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}