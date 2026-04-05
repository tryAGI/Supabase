#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// Get restore points for project
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.V1RestorePointResponse> V1GetRestorePointAsync(
            string @ref,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}