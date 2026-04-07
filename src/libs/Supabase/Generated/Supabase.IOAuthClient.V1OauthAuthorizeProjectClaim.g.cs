#nullable enable

namespace Supabase
{
    public partial interface IOAuthClient
    {
        /// <summary>
        /// Authorize user through oauth and claim a project<br/>
        /// Initiates the OAuth authorization flow for the specified provider. After successful authentication, the user can claim ownership of the specified project.
        /// </summary>
        /// <param name="projectRef">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="clientId">
        /// Example: 66666666-6666-4666-8666-666666666666
        /// </param>
        /// <param name="responseType">
        /// Example: code
        /// </param>
        /// <param name="redirectUri">
        /// Example: https://app.acme.com/auth/callback
        /// </param>
        /// <param name="state">
        /// Example: st_9f4d3a206b2e4a7e8c91
        /// </param>
        /// <param name="responseMode">
        /// Example: query
        /// </param>
        /// <param name="codeChallenge">
        /// Example: Z_P4EKbGwIkA01e3Y5fp4tMCvn_Ae5nUw7qY7XwkTrQ
        /// </param>
        /// <param name="codeChallengeMethod">
        /// Example: S256
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task V1OauthAuthorizeProjectClaimAsync(
            string projectRef,
            global::System.Guid clientId,
            global::Supabase.V1OauthAuthorizeProjectClaimResponseType responseType,
            string redirectUri,
            string? state = default,
            string? responseMode = default,
            string? codeChallenge = default,
            global::Supabase.V1OauthAuthorizeProjectClaimCodeChallengeMethod? codeChallengeMethod = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}