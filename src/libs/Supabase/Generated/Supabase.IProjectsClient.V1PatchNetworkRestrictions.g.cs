#nullable enable

namespace Supabase
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// [Alpha] Updates project's network restrictions by adding or removing CIDRs
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "SUPABASE_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Supabase.NetworkRestrictionsV2Response> V1PatchNetworkRestrictionsAsync(
            string @ref,

            global::Supabase.NetworkRestrictionsPatchRequest request,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [Alpha] Updates project's network restrictions by adding or removing CIDRs
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "SUPABASE_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Supabase.AutoSDKHttpResponse<global::Supabase.NetworkRestrictionsV2Response>> V1PatchNetworkRestrictionsAsResponseAsync(
            string @ref,

            global::Supabase.NetworkRestrictionsPatchRequest request,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [Alpha] Updates project's network restrictions by adding or removing CIDRs
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="add"></param>
        /// <param name="remove"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "SUPABASE_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Supabase.NetworkRestrictionsV2Response> V1PatchNetworkRestrictionsAsync(
            string @ref,
            global::Supabase.NetworkRestrictionsPatchRequestAdd? add = default,
            global::Supabase.NetworkRestrictionsPatchRequestRemove? remove = default,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}