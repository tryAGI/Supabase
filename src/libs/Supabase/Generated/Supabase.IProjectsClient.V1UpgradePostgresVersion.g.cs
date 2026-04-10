#nullable enable

namespace Supabase
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// [Beta] Upgrades the project's Postgres version
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "SUPABASE_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Supabase.ProjectUpgradeInitiateResponse> V1UpgradePostgresVersionAsync(
            string @ref,

            global::Supabase.UpgradeDatabaseBody request,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [Beta] Upgrades the project's Postgres version
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="targetVersion"></param>
        /// <param name="releaseChannel"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "SUPABASE_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Supabase.ProjectUpgradeInitiateResponse> V1UpgradePostgresVersionAsync(
            string @ref,
            string targetVersion,
            global::Supabase.UpgradeDatabaseBodyReleaseChannel? releaseChannel = default,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}