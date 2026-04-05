#nullable enable

namespace Supabase
{
    public partial interface IOAuthClient
    {
        /// <summary>
        /// Authorize user through oauth and claim a project<br/>
        /// Initiates the OAuth authorization flow for the specified provider. After successful authentication, the user can claim ownership of the specified project.
        /// </summary>
        /// <param name="projectRef"></param>
        /// <param name="clientId"></param>
        /// <param name="responseType"></param>
        /// <param name="redirectUri"></param>
        /// <param name="state"></param>
        /// <param name="responseMode"></param>
        /// <param name="codeChallenge"></param>
        /// <param name="codeChallengeMethod"></param>
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