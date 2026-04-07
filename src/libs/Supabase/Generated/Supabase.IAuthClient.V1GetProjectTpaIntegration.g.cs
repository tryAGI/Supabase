#nullable enable

namespace Supabase
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Get a third-party integration
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="tpaId">
        /// Example: 88888888-8888-4888-8888-888888888888
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.ThirdPartyAuth> V1GetProjectTpaIntegrationAsync(
            string @ref,
            global::System.Guid tpaId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}