#nullable enable

namespace Supabase
{
    public partial interface IStorageClient
    {
        /// <summary>
        /// Lists all buckets
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Supabase.V1StorageBucketResponse>> V1ListAllBucketsAsync(
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}