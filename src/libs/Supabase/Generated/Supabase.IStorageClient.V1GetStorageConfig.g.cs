#nullable enable

namespace Supabase
{
    public partial interface IStorageClient
    {
        /// <summary>
        /// Gets project's storage config
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.StorageConfigResponse> V1GetStorageConfigAsync(
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}