#nullable enable

namespace Supabase
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Lists all third-party auth integrations
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Supabase.ThirdPartyAuth>> V1ListProjectTpaIntegrationsAsync(
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}