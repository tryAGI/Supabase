#nullable enable

namespace Supabase
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Update the status of an action run<br/>
        /// Updates the status of an ongoing action run.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="runId">
        /// Example: run_01hq3q9m7y5q7e4a7x2c8m1p4n
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.UpdateRunStatusResponse> V1UpdateActionRunStatusAsync(
            string @ref,
            string runId,

            global::Supabase.UpdateRunStatusBody request,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the status of an action run<br/>
        /// Updates the status of an ongoing action run.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="runId">
        /// Example: run_01hq3q9m7y5q7e4a7x2c8m1p4n
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.AutoSDKHttpResponse<global::Supabase.UpdateRunStatusResponse>> V1UpdateActionRunStatusAsResponseAsync(
            string @ref,
            string runId,

            global::Supabase.UpdateRunStatusBody request,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the status of an action run<br/>
        /// Updates the status of an ongoing action run.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="runId">
        /// Example: run_01hq3q9m7y5q7e4a7x2c8m1p4n
        /// </param>
        /// <param name="clone"></param>
        /// <param name="pull"></param>
        /// <param name="health"></param>
        /// <param name="configure"></param>
        /// <param name="migrate"></param>
        /// <param name="seed"></param>
        /// <param name="deploy"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.UpdateRunStatusResponse> V1UpdateActionRunStatusAsync(
            string @ref,
            string runId,
            global::Supabase.UpdateRunStatusBodyClone? clone = default,
            global::Supabase.UpdateRunStatusBodyPull? pull = default,
            global::Supabase.UpdateRunStatusBodyHealth? health = default,
            global::Supabase.UpdateRunStatusBodyConfigure? configure = default,
            global::Supabase.UpdateRunStatusBodyMigrate? migrate = default,
            global::Supabase.UpdateRunStatusBodySeed? seed = default,
            global::Supabase.UpdateRunStatusBodyDeploy? deploy = default,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}