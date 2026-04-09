
#nullable enable

namespace Supabase
{
    public partial class OAuthClient
    {


        private static readonly global::Supabase.EndPointSecurityRequirement s_V1AuthorizeUserSecurityRequirement0 =
            new global::Supabase.EndPointSecurityRequirement
            {
                Authorizations = new global::Supabase.EndPointAuthorizationRequirement[]
                {                    new global::Supabase.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Supabase.EndPointSecurityRequirement[] s_V1AuthorizeUserSecurityRequirements =
            new global::Supabase.EndPointSecurityRequirement[]
            {                s_V1AuthorizeUserSecurityRequirement0,
            };
        partial void PrepareV1AuthorizeUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid clientId,
            ref global::Supabase.V1AuthorizeUserResponseType responseType,
            ref string redirectUri,
            ref string? scope,
            ref string? state,
            ref string? responseMode,
            ref string? codeChallenge,
            ref global::Supabase.V1AuthorizeUserCodeChallengeMethod? codeChallengeMethod,
            ref string? organizationSlug,
            ref string? resource);
        partial void PrepareV1AuthorizeUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid clientId,
            global::Supabase.V1AuthorizeUserResponseType responseType,
            string redirectUri,
            string? scope,
            string? state,
            string? responseMode,
            string? codeChallenge,
            global::Supabase.V1AuthorizeUserCodeChallengeMethod? codeChallengeMethod,
            string? organizationSlug,
            string? resource);
        partial void ProcessV1AuthorizeUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

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
        public async global::System.Threading.Tasks.Task V1AuthorizeUserAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareV1AuthorizeUserArguments(
                httpClient: HttpClient,
                clientId: ref clientId,
                responseType: ref responseType,
                redirectUri: ref redirectUri,
                scope: ref scope,
                state: ref state,
                responseMode: ref responseMode,
                codeChallenge: ref codeChallenge,
                codeChallengeMethod: ref codeChallengeMethod,
                organizationSlug: ref organizationSlug,
                resource: ref resource);


            var __authorizations = global::Supabase.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_V1AuthorizeUserSecurityRequirements,
                operationName: "V1AuthorizeUserAsync");

            var __pathBuilder = new global::Supabase.PathBuilder(
                path: "/v1/oauth/authorize",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("client_id", clientId.ToString()!)
                .AddRequiredParameter("response_type", responseType.ToValueString())
                .AddRequiredParameter("redirect_uri", redirectUri)
                .AddOptionalParameter("scope", scope)
                .AddOptionalParameter("state", state)
                .AddOptionalParameter("response_mode", responseMode)
                .AddOptionalParameter("code_challenge", codeChallenge)
                .AddOptionalParameter("code_challenge_method", codeChallengeMethod?.ToValueString())
                .AddOptionalParameter("organization_slug", organizationSlug)
                .AddOptionalParameter("resource", resource) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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
            PrepareV1AuthorizeUserRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                clientId: clientId,
                responseType: responseType,
                redirectUri: redirectUri,
                scope: scope,
                state: state,
                responseMode: responseMode,
                codeChallenge: codeChallenge,
                codeChallengeMethod: codeChallengeMethod,
                organizationSlug: organizationSlug,
                resource: resource);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessV1AuthorizeUserResponse(
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