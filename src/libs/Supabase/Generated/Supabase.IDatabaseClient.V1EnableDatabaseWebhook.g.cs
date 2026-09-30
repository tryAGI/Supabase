#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// Enables Database Webhooks on the project<br/>
        /// This is an **experimental** endpoint. It is subject to change or removal in future versions. Use it with caution, as it may not remain supported or stable.<br/>
        /// This endpoint is currently in its **Beta** stage.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task V1EnableDatabaseWebhookAsync(
            string @ref,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Enables Database Webhooks on the project<br/>
        /// This is an **experimental** endpoint. It is subject to change or removal in future versions. Use it with caution, as it may not remain supported or stable.<br/>
        /// This endpoint is currently in its **Beta** stage.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.AutoSDKHttpResponse> V1EnableDatabaseWebhookAsResponseAsync(
            string @ref,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}