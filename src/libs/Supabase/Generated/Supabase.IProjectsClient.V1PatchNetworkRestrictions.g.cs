#nullable enable

namespace Supabase
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Updates project's network restrictions by adding or removing CIDRs<br/>
        /// This is an **experimental** endpoint. It is subject to change or removal in future versions. Use it with caution, as it may not remain supported or stable.<br/>
        /// This endpoint is currently in its **Alpha** stage.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.NetworkRestrictionsV2ResponseOutput> V1PatchNetworkRestrictionsAsync(
            string @ref,

            global::Supabase.NetworkRestrictionsPatchRequest request,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates project's network restrictions by adding or removing CIDRs<br/>
        /// This is an **experimental** endpoint. It is subject to change or removal in future versions. Use it with caution, as it may not remain supported or stable.<br/>
        /// This endpoint is currently in its **Alpha** stage.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.AutoSDKHttpResponse<global::Supabase.NetworkRestrictionsV2ResponseOutput>> V1PatchNetworkRestrictionsAsResponseAsync(
            string @ref,

            global::Supabase.NetworkRestrictionsPatchRequest request,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates project's network restrictions by adding or removing CIDRs<br/>
        /// This is an **experimental** endpoint. It is subject to change or removal in future versions. Use it with caution, as it may not remain supported or stable.<br/>
        /// This endpoint is currently in its **Alpha** stage.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="add"></param>
        /// <param name="remove"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.NetworkRestrictionsV2ResponseOutput> V1PatchNetworkRestrictionsAsync(
            string @ref,
            global::Supabase.NetworkRestrictionsPatchRequestAdd? add = default,
            global::Supabase.NetworkRestrictionsPatchRequestRemove? remove = default,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}