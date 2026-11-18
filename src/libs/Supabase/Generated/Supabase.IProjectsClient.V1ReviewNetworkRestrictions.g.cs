#nullable enable

namespace Supabase
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Applies or rejects the change in review in a project's network restrictions<br/>
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
        global::System.Threading.Tasks.Task<global::Supabase.NetworkRestrictionsResponseOutput> V1ReviewNetworkRestrictionsAsync(
            string @ref,

            global::Supabase.NetworkRestrictionsReviewRequest request,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Applies or rejects the change in review in a project's network restrictions<br/>
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
        global::System.Threading.Tasks.Task<global::Supabase.AutoSDKHttpResponse<global::Supabase.NetworkRestrictionsResponseOutput>> V1ReviewNetworkRestrictionsAsResponseAsync(
            string @ref,

            global::Supabase.NetworkRestrictionsReviewRequest request,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Applies or rejects the change in review in a project's network restrictions<br/>
        /// This is an **experimental** endpoint. It is subject to change or removal in future versions. Use it with caution, as it may not remain supported or stable.<br/>
        /// This endpoint is currently in its **Alpha** stage.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="action">
        /// `apply` replaces the enforced list with the pending one and applies it. `reject` discards the pending one and keeps the enforced list.
        /// </param>
        /// <param name="requestedAt">
        /// The `pending_requested_at` of the change being reviewed. Only that change is resolved: if another one has replaced it, the request gets a 409.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.NetworkRestrictionsResponseOutput> V1ReviewNetworkRestrictionsAsync(
            string @ref,
            global::Supabase.NetworkRestrictionsReviewRequestAction action,
            global::System.DateTime requestedAt,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}