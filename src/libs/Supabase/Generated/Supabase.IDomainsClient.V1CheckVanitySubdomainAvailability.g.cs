#nullable enable

namespace Supabase
{
    public partial interface IDomainsClient
    {
        /// <summary>
        /// [Beta] Checks vanity subdomain availability
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "SUPABASE_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Supabase.SubdomainAvailabilityResponse> V1CheckVanitySubdomainAvailabilityAsync(
            string @ref,

            global::Supabase.VanitySubdomainBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [Beta] Checks vanity subdomain availability
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="vanitySubdomain"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "SUPABASE_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Supabase.SubdomainAvailabilityResponse> V1CheckVanitySubdomainAvailabilityAsync(
            string @ref,
            string vanitySubdomain,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}