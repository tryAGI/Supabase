#nullable enable

namespace Supabase
{
    public partial interface IDomainsClient
    {
        /// <summary>
        /// [Beta] Gets current vanity subdomain config
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "SUPABASE_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Supabase.VanitySubdomainConfigResponse> V1GetVanitySubdomainConfigAsync(
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}