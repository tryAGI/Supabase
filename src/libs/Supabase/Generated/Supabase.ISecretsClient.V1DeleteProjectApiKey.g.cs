#nullable enable

namespace Supabase
{
    public partial interface ISecretsClient
    {
        /// <summary>
        /// Deletes an API key for the project
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="id"></param>
        /// <param name="reveal"></param>
        /// <param name="wasCompromised"></param>
        /// <param name="reason"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.ApiKeyResponse> V1DeleteProjectApiKeyAsync(
            string @ref,
            global::System.Guid id,
            bool? reveal = default,
            bool? wasCompromised = default,
            string? reason = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}