#nullable enable

namespace Supabase
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Creates a new third-party auth integration
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.ThirdPartyAuth> V1CreateProjectTpaIntegrationAsync(
            string @ref,

            global::Supabase.CreateThirdPartyAuthBody request,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new third-party auth integration
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="oidcIssuerUrl"></param>
        /// <param name="jwksUrl"></param>
        /// <param name="customJwks"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.ThirdPartyAuth> V1CreateProjectTpaIntegrationAsync(
            string @ref,
            string? oidcIssuerUrl = default,
            string? jwksUrl = default,
            object? customJwks = default,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}