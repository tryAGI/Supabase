
#nullable enable

namespace Supabase
{
    public partial class OAuthClient
    {
        partial void PrepareV1OauthAuthorizeProjectClaimArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string projectRef,
            ref global::System.Guid clientId,
            ref global::Supabase.V1OauthAuthorizeProjectClaimResponseType responseType,
            ref string redirectUri,
            ref string? state,
            ref string? responseMode,
            ref string? codeChallenge,
            ref global::Supabase.V1OauthAuthorizeProjectClaimCodeChallengeMethod? codeChallengeMethod);
        partial void PrepareV1OauthAuthorizeProjectClaimRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string projectRef,
            global::System.Guid clientId,
            global::Supabase.V1OauthAuthorizeProjectClaimResponseType responseType,
            string redirectUri,
            string? state,
            string? responseMode,
            string? codeChallenge,
            global::Supabase.V1OauthAuthorizeProjectClaimCodeChallengeMethod? codeChallengeMethod);
        partial void ProcessV1OauthAuthorizeProjectClaimResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

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
        public async global::System.Threading.Tasks.Task V1OauthAuthorizeProjectClaimAsync(
            string projectRef,
            global::System.Guid clientId,
            global::Supabase.V1OauthAuthorizeProjectClaimResponseType responseType,
            string redirectUri,
            string? state = default,
            string? responseMode = default,
            string? codeChallenge = default,
            global::Supabase.V1OauthAuthorizeProjectClaimCodeChallengeMethod? codeChallengeMethod = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareV1OauthAuthorizeProjectClaimArguments(
                httpClient: HttpClient,
                projectRef: ref projectRef,
                clientId: ref clientId,
                responseType: ref responseType,
                redirectUri: ref redirectUri,
                state: ref state,
                responseMode: ref responseMode,
                codeChallenge: ref codeChallenge,
                codeChallengeMethod: ref codeChallengeMethod);

            var __pathBuilder = new global::Supabase.PathBuilder(
                path: "/v1/oauth/authorize/project-claim",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("project_ref", projectRef)
                .AddRequiredParameter("client_id", clientId.ToString()!)
                .AddRequiredParameter("response_type", responseType.ToValueString())
                .AddRequiredParameter("redirect_uri", redirectUri)
                .AddOptionalParameter("state", state)
                .AddOptionalParameter("response_mode", responseMode)
                .AddOptionalParameter("code_challenge", codeChallenge)
                .AddOptionalParameter("code_challenge_method", codeChallengeMethod?.ToValueString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareV1OauthAuthorizeProjectClaimRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                projectRef: projectRef,
                clientId: clientId,
                responseType: responseType,
                redirectUri: redirectUri,
                state: state,
                responseMode: responseMode,
                codeChallenge: codeChallenge,
                codeChallengeMethod: codeChallengeMethod);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessV1OauthAuthorizeProjectClaimResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Supabase.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Supabase.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
    }
}