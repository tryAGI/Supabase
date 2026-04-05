#nullable enable

namespace Supabase
{
    public partial interface ISecretsClient
    {
        /// <summary>
        /// Get API key
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="id"></param>
        /// <param name="reveal"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.ApiKeyResponse> V1GetProjectApiKeyAsync(
            string @ref,
            global::System.Guid id,
            bool? reveal = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}