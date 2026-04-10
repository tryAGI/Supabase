#nullable enable

namespace Supabase
{
    public partial interface ISecretsClient
    {
        /// <summary>
        /// Check whether JWT based legacy (anon, service_role) API keys are enabled. This API endpoint will be removed in the future, check for HTTP 404 Not Found.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.LegacyApiKeysResponse> V1GetProjectLegacyApiKeysAsync(
            string @ref,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}