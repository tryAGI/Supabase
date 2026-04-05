#nullable enable

namespace Supabase
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Update a signing key, mainly its status
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ref"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.SigningKeyResponse> V1UpdateProjectSigningKeyAsync(
            global::System.Guid id,
            string @ref,

            global::Supabase.UpdateSigningKeyBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a signing key, mainly its status
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ref"></param>
        /// <param name="status"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.SigningKeyResponse> V1UpdateProjectSigningKeyAsync(
            global::System.Guid id,
            string @ref,
            global::Supabase.UpdateSigningKeyBodyStatus status,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}