#nullable enable

namespace Supabase
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Removes a SSO provider by its UUID
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="providerId">
        /// Example: 77777777-7777-4777-8777-777777777777
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.DeleteProviderResponse> V1DeleteASsoProviderAsync(
            string @ref,
            global::System.Guid providerId,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Removes a SSO provider by its UUID
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="providerId">
        /// Example: 77777777-7777-4777-8777-777777777777
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.AutoSDKHttpResponse<global::Supabase.DeleteProviderResponse>> V1DeleteASsoProviderAsResponseAsync(
            string @ref,
            global::System.Guid providerId,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}