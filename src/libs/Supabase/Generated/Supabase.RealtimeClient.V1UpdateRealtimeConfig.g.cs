
#nullable enable

namespace Supabase
{
    public partial class RealtimeClient
    {
        partial void PrepareV1UpdateRealtimeConfigArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string @ref,
            global::Supabase.UpdateRealtimeConfigBody request);
        partial void PrepareV1UpdateRealtimeConfigRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string @ref,
            global::Supabase.UpdateRealtimeConfigBody request);
        partial void ProcessV1UpdateRealtimeConfigResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Updates realtime configuration
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        public async global::System.Threading.Tasks.Task V1UpdateRealtimeConfigAsync(
            string @ref,

            global::Supabase.UpdateRealtimeConfigBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareV1UpdateRealtimeConfigArguments(
                httpClient: HttpClient,
                @ref: ref @ref,
                request: request);

            var __pathBuilder = new global::Supabase.PathBuilder(
                path: $"/v1/projects/{@ref}/config/realtime",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareV1UpdateRealtimeConfigRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                @ref: @ref,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessV1UpdateRealtimeConfigResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::Supabase.ApiException(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::Supabase.ApiException(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::Supabase.ApiException(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_429,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
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
        /// <summary>
        /// Updates realtime configuration
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="privateOnly">
        /// Whether to only allow private channels
        /// </param>
        /// <param name="connectionPool">
        /// Sets connection pool size for Realtime Authorization
        /// </param>
        /// <param name="maxConcurrentUsers">
        /// Sets maximum number of concurrent users rate limit
        /// </param>
        /// <param name="maxEventsPerSecond">
        /// Sets maximum number of events per second rate per channel limit
        /// </param>
        /// <param name="maxBytesPerSecond">
        /// Sets maximum number of bytes per second rate per channel limit
        /// </param>
        /// <param name="maxChannelsPerClient">
        /// Sets maximum number of channels per client rate limit
        /// </param>
        /// <param name="maxJoinsPerSecond">
        /// Sets maximum number of joins per second rate limit
        /// </param>
        /// <param name="maxPresenceEventsPerSecond">
        /// Sets maximum number of presence events per second rate limit
        /// </param>
        /// <param name="maxPayloadSizeInKb">
        /// Sets maximum number of payload size in KB rate limit
        /// </param>
        /// <param name="suspend">
        /// Disables the Realtime service for this project when true. Set to false to re-enable it.
        /// </param>
        /// <param name="presenceEnabled">
        /// Whether to enable presence
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task V1UpdateRealtimeConfigAsync(
            string @ref,
            bool? privateOnly = default,
            int? connectionPool = default,
            int? maxConcurrentUsers = default,
            int? maxEventsPerSecond = default,
            long? maxBytesPerSecond = default,
            int? maxChannelsPerClient = default,
            int? maxJoinsPerSecond = default,
            int? maxPresenceEventsPerSecond = default,
            int? maxPayloadSizeInKb = default,
            bool? suspend = default,
            bool? presenceEnabled = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Supabase.UpdateRealtimeConfigBody
            {
                PrivateOnly = privateOnly,
                ConnectionPool = connectionPool,
                MaxConcurrentUsers = maxConcurrentUsers,
                MaxEventsPerSecond = maxEventsPerSecond,
                MaxBytesPerSecond = maxBytesPerSecond,
                MaxChannelsPerClient = maxChannelsPerClient,
                MaxJoinsPerSecond = maxJoinsPerSecond,
                MaxPresenceEventsPerSecond = maxPresenceEventsPerSecond,
                MaxPayloadSizeInKb = maxPayloadSizeInKb,
                Suspend = suspend,
                PresenceEnabled = presenceEnabled,
            };

            await V1UpdateRealtimeConfigAsync(
                @ref: @ref,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}