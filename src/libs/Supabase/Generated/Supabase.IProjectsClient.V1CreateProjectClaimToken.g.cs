#nullable enable

namespace Supabase
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Creates project claim token
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.CreateProjectClaimTokenResponse> V1CreateProjectClaimTokenAsync(
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}