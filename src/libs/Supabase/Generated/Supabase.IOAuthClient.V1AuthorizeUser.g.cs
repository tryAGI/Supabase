#nullable enable

namespace Supabase
{
    public partial interface IOAuthClient
    {
        /// <summary>
        /// [Beta] Authorize user through oauth
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="responseType"></param>
        /// <param name="redirectUri"></param>
        /// <param name="scope"></param>
        /// <param name="state"></param>
        /// <param name="responseMode"></param>
        /// <param name="codeChallenge"></param>
        /// <param name="codeChallengeMethod"></param>
        /// <param name="organizationSlug"></param>
        /// <param name="resource"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "SUPABASE_BETA_001")]
#endif
        global::System.Threading.Tasks.Task V1AuthorizeUserAsync(
            global::System.Guid clientId,
            global::Supabase.V1AuthorizeUserResponseType responseType,
            string redirectUri,
            string? scope = default,
            string? state = default,
            string? responseMode = default,
            string? codeChallenge = default,
            global::Supabase.V1AuthorizeUserCodeChallengeMethod? codeChallengeMethod = default,
            string? organizationSlug = default,
            string? resource = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}