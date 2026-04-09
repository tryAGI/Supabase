
#nullable enable

namespace Supabase
{
    public partial class DatabaseClient
    {


        private static readonly global::Supabase.EndPointSecurityRequirement s_V1ListAllSnippetsSecurityRequirement0 =
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
        private static readonly global::Supabase.EndPointSecurityRequirement[] s_V1ListAllSnippetsSecurityRequirements =
            new global::Supabase.EndPointSecurityRequirement[]
            {                s_V1ListAllSnippetsSecurityRequirement0,
            };
        partial void PrepareV1ListAllSnippetsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? projectRef,
            ref string? cursor,
            ref string? limit,
            ref global::Supabase.V1ListAllSnippetsSortBy? sortBy,
            ref global::Supabase.V1ListAllSnippetsSortOrder? sortOrder);
        partial void PrepareV1ListAllSnippetsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? projectRef,
            string? cursor,
            string? limit,
            global::Supabase.V1ListAllSnippetsSortBy? sortBy,
            global::Supabase.V1ListAllSnippetsSortOrder? sortOrder);
        partial void ProcessV1ListAllSnippetsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessV1ListAllSnippetsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Lists SQL snippets for the logged in user
        /// </summary>
        /// <param name="projectRef">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="limit"></param>
        /// <param name="sortBy"></param>
        /// <param name="sortOrder"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Supabase.SnippetList> V1ListAllSnippetsAsync(
            string? projectRef = default,
            string? cursor = default,
            string? limit = default,
            global::Supabase.V1ListAllSnippetsSortBy? sortBy = default,
            global::Supabase.V1ListAllSnippetsSortOrder? sortOrder = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareV1ListAllSnippetsArguments(
                httpClient: HttpClient,
                projectRef: ref projectRef,
                cursor: ref cursor,
                limit: ref limit,
                sortBy: ref sortBy,
                sortOrder: ref sortOrder);


            var __authorizations = global::Supabase.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_V1ListAllSnippetsSecurityRequirements,
                operationName: "V1ListAllSnippetsAsync");

            var __pathBuilder = new global::Supabase.PathBuilder(
                path: "/v1/snippets",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("project_ref", projectRef)
                .AddOptionalParameter("cursor", cursor)
                .AddOptionalParameter("limit", limit)
                .AddOptionalParameter("sort_by", sortBy?.ToValueString())
                .AddOptionalParameter("sort_order", sortOrder?.ToValueString()) 
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
            PrepareV1ListAllSnippetsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                projectRef: projectRef,
                cursor: cursor,
                limit: limit,
                sortBy: sortBy,
                sortOrder: sortOrder);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessV1ListAllSnippetsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::Supabase.ApiException(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

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
                ProcessV1ListAllSnippetsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Supabase.SnippetList.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Supabase.SnippetList.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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