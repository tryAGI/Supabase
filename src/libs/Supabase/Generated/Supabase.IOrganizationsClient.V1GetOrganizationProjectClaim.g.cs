#nullable enable

namespace Supabase
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Gets project details for the specified organization and claim token
        /// </summary>
        /// <param name="slug">
        /// Example: tsrqponmlkjihgfedcba
        /// </param>
        /// <param name="token">
        /// Example: 0123456789abcdef0123456789abcdef01234567
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.OrganizationProjectClaimResponse> V1GetOrganizationProjectClaimAsync(
            string slug,
            string token,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets project details for the specified organization and claim token
        /// </summary>
        /// <param name="slug">
        /// Example: tsrqponmlkjihgfedcba
        /// </param>
        /// <param name="token">
        /// Example: 0123456789abcdef0123456789abcdef01234567
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.AutoSDKHttpResponse<global::Supabase.OrganizationProjectClaimResponse>> V1GetOrganizationProjectClaimAsResponseAsync(
            string slug,
            string token,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}