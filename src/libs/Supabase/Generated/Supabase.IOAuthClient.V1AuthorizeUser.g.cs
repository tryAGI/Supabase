#nullable enable

namespace Supabase
{
    public partial interface IOAuthClient
    {
        /// <summary>
        /// [Beta] Authorize user through oauth
        /// </summary>
        /// <param name="clientId">
        /// Example: 66666666-6666-4666-8666-666666666666
        /// </param>
        /// <param name="responseType">
        /// Example: code
        /// </param>
        /// <param name="redirectUri">
        /// Example: https://app.acme.com/auth/callback
        /// </param>
        /// <param name="scope">
        /// Example: projects:read projects:write
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
        /// <param name="organizationSlug">
        /// Example: tsrqponmlkjihgfedcba
        /// </param>
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