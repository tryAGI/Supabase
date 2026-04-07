#nullable enable

namespace Supabase
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Create a new signing key for the project in standby status
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.SigningKeyResponse> V1CreateProjectSigningKeyAsync(
            string @ref,

            global::Supabase.CreateSigningKeyBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new signing key for the project in standby status
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="algorithm"></param>
        /// <param name="status"></param>
        /// <param name="privateJwk"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.SigningKeyResponse> V1CreateProjectSigningKeyAsync(
            string @ref,
            global::Supabase.CreateSigningKeyBodyAlgorithm algorithm,
            global::Supabase.CreateSigningKeyBodyStatus? status = default,
            global::Supabase.PrivateJwk? privateJwk = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}