#nullable enable

namespace Supabase
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Updates a SSO provider by its UUID
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="providerId">
        /// Example: 77777777-7777-4777-8777-777777777777
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.UpdateProviderResponse> V1UpdateASsoProviderAsync(
            string @ref,
            global::System.Guid providerId,

            global::Supabase.UpdateProviderBody request,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a SSO provider by its UUID
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="providerId">
        /// Example: 77777777-7777-4777-8777-777777777777
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.AutoSDKHttpResponse<global::Supabase.UpdateProviderResponse>> V1UpdateASsoProviderAsResponseAsync(
            string @ref,
            global::System.Guid providerId,

            global::Supabase.UpdateProviderBody request,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a SSO provider by its UUID
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="providerId">
        /// Example: 77777777-7777-4777-8777-777777777777
        /// </param>
        /// <param name="metadataXml"></param>
        /// <param name="metadataUrl"></param>
        /// <param name="domains"></param>
        /// <param name="attributeMapping"></param>
        /// <param name="nameIdFormat"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.UpdateProviderResponse> V1UpdateASsoProviderAsync(
            string @ref,
            global::System.Guid providerId,
            string? metadataXml = default,
            string? metadataUrl = default,
            global::System.Collections.Generic.IList<string>? domains = default,
            global::Supabase.UpdateProviderBodyAttributeMapping? attributeMapping = default,
            global::Supabase.UpdateProviderBodyNameIdFormat? nameIdFormat = default,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}