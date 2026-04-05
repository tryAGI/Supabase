#nullable enable

namespace Supabase
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Create a database branch<br/>
        /// Creates a database branch from the specified project.
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.BranchResponse> V1CreateABranchAsync(
            string @ref,

            global::Supabase.CreateBranchBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a database branch<br/>
        /// Creates a database branch from the specified project.
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="branchName"></param>
        /// <param name="gitBranch"></param>
        /// <param name="isDefault"></param>
        /// <param name="persistent"></param>
        /// <param name="region"></param>
        /// <param name="desiredInstanceSize"></param>
        /// <param name="releaseChannel">
        /// Release channel. If not provided, GA will be used.
        /// </param>
        /// <param name="postgresEngine">
        /// Postgres engine version. If not provided, the latest version will be used.
        /// </param>
        /// <param name="secrets"></param>
        /// <param name="withData"></param>
        /// <param name="notifyUrl">
        /// HTTP endpoint to receive branch status updates.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.BranchResponse> V1CreateABranchAsync(
            string @ref,
            string branchName,
            string? gitBranch = default,
            bool? isDefault = default,
            bool? persistent = default,
            string? region = default,
            global::Supabase.CreateBranchBodyDesiredInstanceSize? desiredInstanceSize = default,
            global::Supabase.CreateBranchBodyReleaseChannel? releaseChannel = default,
            global::Supabase.CreateBranchBodyPostgresEngine? postgresEngine = default,
            global::System.Collections.Generic.Dictionary<string, string>? secrets = default,
            bool? withData = default,
            string? notifyUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}