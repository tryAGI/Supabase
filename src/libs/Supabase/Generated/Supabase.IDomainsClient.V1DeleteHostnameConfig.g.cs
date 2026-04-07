#nullable enable

namespace Supabase
{
    public partial interface IDomainsClient
    {
        /// <summary>
        /// [Beta] Deletes a project's custom hostname configuration
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "SUPABASE_BETA_001")]
#endif
        global::System.Threading.Tasks.Task V1DeleteHostnameConfigAsync(
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}