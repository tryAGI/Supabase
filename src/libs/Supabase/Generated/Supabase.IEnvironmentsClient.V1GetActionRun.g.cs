#nullable enable

namespace Supabase
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Get the status of an action run<br/>
        /// Returns the current status of the specified action run.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="runId">
        /// Example: run_01hq3q9m7y5q7e4a7x2c8m1p4n
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.ActionRunResponse> V1GetActionRunAsync(
            string @ref,
            string runId,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}