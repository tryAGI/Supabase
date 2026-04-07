#nullable enable

namespace Supabase
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// [Beta] Updates project's network restrictions
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
        global::System.Threading.Tasks.Task<global::Supabase.NetworkRestrictionsResponse> V1UpdateNetworkRestrictionsAsync(
            string @ref,

            global::Supabase.NetworkRestrictionsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [Beta] Updates project's network restrictions
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="dbAllowedCidrs"></param>
        /// <param name="dbAllowedCidrsV6"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "SUPABASE_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Supabase.NetworkRestrictionsResponse> V1UpdateNetworkRestrictionsAsync(
            string @ref,
            global::System.Collections.Generic.IList<string>? dbAllowedCidrs = default,
            global::System.Collections.Generic.IList<string>? dbAllowedCidrsV6 = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}