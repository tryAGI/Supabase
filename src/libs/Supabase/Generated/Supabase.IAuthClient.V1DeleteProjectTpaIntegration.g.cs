#nullable enable

namespace Supabase
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Removes a third-party auth integration
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="tpaId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.ThirdPartyAuth> V1DeleteProjectTpaIntegrationAsync(
            string @ref,
            global::System.Guid tpaId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}