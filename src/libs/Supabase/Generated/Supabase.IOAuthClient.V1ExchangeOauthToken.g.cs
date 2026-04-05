#nullable enable

namespace Supabase
{
    public partial interface IOAuthClient
    {
        /// <summary>
        /// [Beta] Exchange auth code for user's access and refresh token
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "SUPABASE_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Supabase.OAuthTokenResponse> V1ExchangeOauthTokenAsync(

            global::Supabase.OAuthTokenBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [Beta] Exchange auth code for user's access and refresh token
        /// </summary>
        /// <param name="grantType"></param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="code"></param>
        /// <param name="codeVerifier"></param>
        /// <param name="redirectUri"></param>
        /// <param name="refreshToken"></param>
        /// <param name="resource">
        /// Resource indicator for MCP (Model Context Protocol) clients
        /// </param>
        /// <param name="scope"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "SUPABASE_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Supabase.OAuthTokenResponse> V1ExchangeOauthTokenAsync(
            global::Supabase.OAuthTokenBodyGrantType? grantType = default,
            global::System.Guid? clientId = default,
            string? clientSecret = default,
            string? code = default,
            string? codeVerifier = default,
            string? redirectUri = default,
            string? refreshToken = default,
            string? resource = default,
            string? scope = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}