#nullable enable

namespace Supabase
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get disk utilization
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.DiskUtilMetricsResponse> V1GetDiskUtilizationAsync(
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}