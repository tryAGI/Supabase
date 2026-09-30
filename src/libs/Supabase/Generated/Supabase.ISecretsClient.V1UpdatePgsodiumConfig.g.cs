#nullable enable

namespace Supabase
{
    public partial interface ISecretsClient
    {
        /// <summary>
        /// Updates project's pgsodium config. Updating the root_key can cause all data encrypted with the older key to become inaccessible.<br/>
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
        global::System.Threading.Tasks.Task<global::Supabase.PgsodiumConfigResponseOutput> V1UpdatePgsodiumConfigAsync(
            string @ref,

            global::Supabase.UpdatePgsodiumConfigBody request,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates project's pgsodium config. Updating the root_key can cause all data encrypted with the older key to become inaccessible.<br/>
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
        global::System.Threading.Tasks.Task<global::Supabase.AutoSDKHttpResponse<global::Supabase.PgsodiumConfigResponseOutput>> V1UpdatePgsodiumConfigAsResponseAsync(
            string @ref,

            global::Supabase.UpdatePgsodiumConfigBody request,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates project's pgsodium config. Updating the root_key can cause all data encrypted with the older key to become inaccessible.<br/>
        /// This is an **experimental** endpoint. It is subject to change or removal in future versions. Use it with caution, as it may not remain supported or stable.<br/>
        /// This endpoint is currently in its **Beta** stage.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="rootKey">
        /// The pgsodium root key: 32 bytes, hex-encoded (64 characters).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.PgsodiumConfigResponseOutput> V1UpdatePgsodiumConfigAsync(
            string @ref,
            string rootKey,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}