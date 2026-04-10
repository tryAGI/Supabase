#nullable enable

namespace Supabase
{
    public partial interface ISecretsClient
    {
        /// <summary>
        /// Deletes an API key for the project
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="id">
        /// Example: 22222222-2222-4222-8222-222222222222
        /// </param>
        /// <param name="reveal">
        /// Example: true
        /// </param>
        /// <param name="wasCompromised">
        /// Example: false
        /// </param>
        /// <param name="reason">
        /// Example: rotating_key
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.ApiKeyResponse> V1DeleteProjectApiKeyAsync(
            string @ref,
            global::System.Guid id,
            bool? reveal = default,
            bool? wasCompromised = default,
            string? reason = default,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}