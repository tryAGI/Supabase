#nullable enable

namespace Supabase
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Removes a third-party auth integration
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="tpaId">
        /// Example: 88888888-8888-4888-8888-888888888888
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.ThirdPartyAuth> V1DeleteProjectTpaIntegrationAsync(
            string @ref,
            global::System.Guid tpaId,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Removes a third-party auth integration
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="tpaId">
        /// Example: 88888888-8888-4888-8888-888888888888
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.AutoSDKHttpResponse<global::Supabase.ThirdPartyAuth>> V1DeleteProjectTpaIntegrationAsResponseAsync(
            string @ref,
            global::System.Guid tpaId,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}