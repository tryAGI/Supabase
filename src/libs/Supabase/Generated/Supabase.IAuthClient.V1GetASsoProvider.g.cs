#nullable enable

namespace Supabase
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Gets a SSO provider by its UUID
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="providerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.GetProviderResponse> V1GetASsoProviderAsync(
            string @ref,
            global::System.Guid providerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}