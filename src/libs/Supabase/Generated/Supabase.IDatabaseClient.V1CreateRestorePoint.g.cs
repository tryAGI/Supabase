#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// Initiates a creation of a restore point for a database
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.V1RestorePointResponse> V1CreateRestorePointAsync(
            string @ref,

            global::Supabase.V1RestorePointPostBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Initiates a creation of a restore point for a database
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.V1RestorePointResponse> V1CreateRestorePointAsync(
            string @ref,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}