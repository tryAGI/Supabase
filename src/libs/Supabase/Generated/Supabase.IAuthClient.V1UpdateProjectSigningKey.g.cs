#nullable enable

namespace Supabase
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Update a signing key, mainly its status
        /// </summary>
        /// <param name="id">
        /// Example: 33333333-3333-4333-8333-333333333333
        /// </param>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.SigningKeyResponse> V1UpdateProjectSigningKeyAsync(
            global::System.Guid id,
            string @ref,

            global::Supabase.UpdateSigningKeyBody request,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a signing key, mainly its status
        /// </summary>
        /// <param name="id">
        /// Example: 33333333-3333-4333-8333-333333333333
        /// </param>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.AutoSDKHttpResponse<global::Supabase.SigningKeyResponse>> V1UpdateProjectSigningKeyAsResponseAsync(
            global::System.Guid id,
            string @ref,

            global::Supabase.UpdateSigningKeyBody request,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a signing key, mainly its status
        /// </summary>
        /// <param name="id">
        /// Example: 33333333-3333-4333-8333-333333333333
        /// </param>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.SigningKeyResponse> V1UpdateProjectSigningKeyAsync(
            global::System.Guid id,
            string @ref,
            global::Supabase.UpdateSigningKeyBodyStatus status,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}