#nullable enable

namespace Supabase
{
    public partial interface ISecretsClient
    {
        /// <summary>
        /// Updates an API key for the project
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="id"></param>
        /// <param name="reveal"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.ApiKeyResponse> V1UpdateProjectApiKeyAsync(
            string @ref,
            global::System.Guid id,

            global::Supabase.UpdateApiKeyBody request,
            bool? reveal = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates an API key for the project
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="id"></param>
        /// <param name="reveal"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="secretJwtTemplate"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.ApiKeyResponse> V1UpdateProjectApiKeyAsync(
            string @ref,
            global::System.Guid id,
            bool? reveal = default,
            string? name = default,
            string? description = default,
            object? secretJwtTemplate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}