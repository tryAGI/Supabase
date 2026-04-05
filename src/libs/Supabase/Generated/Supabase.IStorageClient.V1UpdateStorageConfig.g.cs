#nullable enable

namespace Supabase
{
    public partial interface IStorageClient
    {
        /// <summary>
        /// Updates project's storage config
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task V1UpdateStorageConfigAsync(
            string @ref,

            global::Supabase.UpdateStorageConfigBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates project's storage config
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="fileSizeLimit"></param>
        /// <param name="features"></param>
        /// <param name="external"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task V1UpdateStorageConfigAsync(
            string @ref,
            long? fileSizeLimit = default,
            global::Supabase.UpdateStorageConfigBodyFeatures? features = default,
            global::Supabase.UpdateStorageConfigBodyExternal? external = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}