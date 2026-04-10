#nullable enable

namespace Supabase
{
    public partial interface IOAuthClient
    {
        /// <summary>
        /// [Beta] Revoke oauth app authorization and it's corresponding tokens
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "SUPABASE_BETA_001")]
#endif
        global::System.Threading.Tasks.Task V1RevokeTokenAsync(

            global::Supabase.OAuthRevokeTokenBody request,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [Beta] Revoke oauth app authorization and it's corresponding tokens
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="refreshToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "SUPABASE_BETA_001")]
#endif
        global::System.Threading.Tasks.Task V1RevokeTokenAsync(
            global::System.Guid clientId,
            string clientSecret,
            string refreshToken,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}