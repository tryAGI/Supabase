
#nullable enable

namespace Supabase
{
    public partial class ProjectsClient
    {


        private static readonly global::Supabase.EndPointSecurityRequirement s_V1GetAvailableRegionsSecurityRequirement0 =
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
        private static readonly global::Supabase.EndPointSecurityRequirement[] s_V1GetAvailableRegionsSecurityRequirements =
            new global::Supabase.EndPointSecurityRequirement[]
            {                s_V1GetAvailableRegionsSecurityRequirement0,
            };
        partial void PrepareV1GetAvailableRegionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string organizationSlug,
            ref global::Supabase.V1GetAvailableRegionsContinent? continent,
            ref global::Supabase.V1GetAvailableRegionsDesiredInstanceSize? desiredInstanceSize);
        partial void PrepareV1GetAvailableRegionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string organizationSlug,
            global::Supabase.V1GetAvailableRegionsContinent? continent,
            global::Supabase.V1GetAvailableRegionsDesiredInstanceSize? desiredInstanceSize);
        partial void ProcessV1GetAvailableRegionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessV1GetAvailableRegionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// [Beta] Gets the list of available regions that can be used for a new project
        /// </summary>
        /// <param name="organizationSlug">
        /// Example: tsrqponmlkjihgfedcba
        /// </param>
        /// <param name="continent">
        /// Example: NA
        /// </param>
        /// <param name="desiredInstanceSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "SUPABASE_BETA_001")]
#endif
        public async global::System.Threading.Tasks.Task<global::Supabase.RegionsInfo> V1GetAvailableRegionsAsync(
            string organizationSlug,
            global::Supabase.V1GetAvailableRegionsContinent? continent = default,
            global::Supabase.V1GetAvailableRegionsDesiredInstanceSize? desiredInstanceSize = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareV1GetAvailableRegionsArguments(
                httpClient: HttpClient,
                organizationSlug: ref organizationSlug,
                continent: ref continent,
                desiredInstanceSize: ref desiredInstanceSize);


            var __authorizations = global::Supabase.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_V1GetAvailableRegionsSecurityRequirements,
                operationName: "V1GetAvailableRegionsAsync");

            var __pathBuilder = new global::Supabase.PathBuilder(
                path: "/v1/projects/available-regions",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("organization_slug", organizationSlug)
                .AddOptionalParameter("continent", continent?.ToValueString())
                .AddOptionalParameter("desired_instance_size", desiredInstanceSize?.ToValueString()) 
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
            PrepareV1GetAvailableRegionsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                organizationSlug: organizationSlug,
                continent: continent,
                desiredInstanceSize: desiredInstanceSize);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessV1GetAvailableRegionsResponse(
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
                ProcessV1GetAvailableRegionsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Supabase.RegionsInfo.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Supabase.RegionsInfo.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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