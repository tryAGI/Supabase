#nullable enable

namespace Supabase
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Get information about a signing key
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ref"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.SigningKeyResponse> V1GetProjectSigningKeyAsync(
            global::System.Guid id,
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}