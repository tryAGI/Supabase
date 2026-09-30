#nullable enable

namespace Supabase
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Gets the latest status of the project's upgrade<br/>
        /// This is an **experimental** endpoint. It is subject to change or removal in future versions. Use it with caution, as it may not remain supported or stable.<br/>
        /// This endpoint is currently in its **Beta** stage.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="trackingId">
        /// Example: 9f4d3a20-6b2e-4a7e-8c91-1d5f3e7a2b4c
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.DatabaseUpgradeStatusResponseOutput> V1GetPostgresUpgradeStatusAsync(
            string @ref,
            string? trackingId = default,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the latest status of the project's upgrade<br/>
        /// This is an **experimental** endpoint. It is subject to change or removal in future versions. Use it with caution, as it may not remain supported or stable.<br/>
        /// This endpoint is currently in its **Beta** stage.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="trackingId">
        /// Example: 9f4d3a20-6b2e-4a7e-8c91-1d5f3e7a2b4c
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.AutoSDKHttpResponse<global::Supabase.DatabaseUpgradeStatusResponseOutput>> V1GetPostgresUpgradeStatusAsResponseAsync(
            string @ref,
            string? trackingId = default,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}