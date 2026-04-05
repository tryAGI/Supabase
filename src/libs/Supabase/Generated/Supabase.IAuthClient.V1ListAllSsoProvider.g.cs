#nullable enable

namespace Supabase
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Lists all SSO providers
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.ListProvidersResponse> V1ListAllSsoProviderAsync(
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}