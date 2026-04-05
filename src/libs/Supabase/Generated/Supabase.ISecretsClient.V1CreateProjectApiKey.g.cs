#nullable enable

namespace Supabase
{
    public partial interface ISecretsClient
    {
        /// <summary>
        /// Creates a new API key for the project
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="reveal"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.ApiKeyResponse> V1CreateProjectApiKeyAsync(
            string @ref,

            global::Supabase.CreateApiKeyBody request,
            bool? reveal = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new API key for the project
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="reveal"></param>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="secretJwtTemplate"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.ApiKeyResponse> V1CreateProjectApiKeyAsync(
            string @ref,
            global::Supabase.CreateApiKeyBodyType type,
            string name,
            bool? reveal = default,
            string? description = default,
            object? secretJwtTemplate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}