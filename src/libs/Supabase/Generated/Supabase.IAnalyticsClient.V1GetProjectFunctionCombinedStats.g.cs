#nullable enable

namespace Supabase
{
    public partial interface IAnalyticsClient
    {
        /// <summary>
        /// Gets a project's function combined statistics
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="interval">
        /// Example: 1hr
        /// </param>
        /// <param name="functionId">
        /// Example: 3c078cce-ad70-4148-9f37-4da362789053
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.AnalyticsResponse> V1GetProjectFunctionCombinedStatsAsync(
            string @ref,
            global::Supabase.V1GetProjectFunctionCombinedStatsInterval interval,
            string functionId,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}