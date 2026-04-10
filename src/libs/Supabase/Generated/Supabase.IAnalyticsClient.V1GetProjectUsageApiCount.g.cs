#nullable enable

namespace Supabase
{
    public partial interface IAnalyticsClient
    {
        /// <summary>
        /// Gets project's usage api counts
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="interval">
        /// Example: 1day
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.V1GetUsageApiCountResponse> V1GetProjectUsageApiCountAsync(
            string @ref,
            global::Supabase.V1GetProjectUsageApiCountInterval? interval = default,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}