#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// Update project's temporary access configuration.<br/>
        /// This is an **experimental** endpoint. It is subject to change or removal in future versions. Use it with caution, as it may not remain supported or stable.<br/>
        /// This endpoint is currently in its **Beta** stage.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.OneOf<global::Supabase.V1UpdateJitAccessConfigResponseVariant1, global::Supabase.V1UpdateJitAccessConfigResponseVariant2>> V1UpdateJitAccessConfigAsync(
            string @ref,

            global::Supabase.JitAccessRequestRequest request,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update project's temporary access configuration.<br/>
        /// This is an **experimental** endpoint. It is subject to change or removal in future versions. Use it with caution, as it may not remain supported or stable.<br/>
        /// This endpoint is currently in its **Beta** stage.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.AutoSDKHttpResponse<global::Supabase.OneOf<global::Supabase.V1UpdateJitAccessConfigResponseVariant1, global::Supabase.V1UpdateJitAccessConfigResponseVariant2>>> V1UpdateJitAccessConfigAsResponseAsync(
            string @ref,

            global::Supabase.JitAccessRequestRequest request,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update project's temporary access configuration.<br/>
        /// This is an **experimental** endpoint. It is subject to change or removal in future versions. Use it with caution, as it may not remain supported or stable.<br/>
        /// This endpoint is currently in its **Beta** stage.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="state"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.OneOf<global::Supabase.V1UpdateJitAccessConfigResponseVariant1, global::Supabase.V1UpdateJitAccessConfigResponseVariant2>> V1UpdateJitAccessConfigAsync(
            string @ref,
            global::Supabase.JitAccessRequestRequestState state,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}