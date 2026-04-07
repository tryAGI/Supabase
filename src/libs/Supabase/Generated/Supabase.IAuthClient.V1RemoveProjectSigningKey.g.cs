#nullable enable

namespace Supabase
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Remove a signing key from a project. Only possible if the key has been in revoked status for a while.
        /// </summary>
        /// <param name="id">
        /// Example: 33333333-3333-4333-8333-333333333333
        /// </param>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.SigningKeyResponse> V1RemoveProjectSigningKeyAsync(
            global::System.Guid id,
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}