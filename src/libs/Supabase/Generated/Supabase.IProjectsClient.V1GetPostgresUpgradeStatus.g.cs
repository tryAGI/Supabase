#nullable enable

namespace Supabase
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// [Beta] Gets the latest status of the project's upgrade
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="trackingId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "SUPABASE_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Supabase.DatabaseUpgradeStatusResponse> V1GetPostgresUpgradeStatusAsync(
            string @ref,
            string? trackingId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}