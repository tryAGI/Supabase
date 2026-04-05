#nullable enable

namespace Supabase
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Gets project disk autoscale config
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.DiskAutoscaleConfig> V1GetProjectDiskAutoscaleConfigAsync(
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}