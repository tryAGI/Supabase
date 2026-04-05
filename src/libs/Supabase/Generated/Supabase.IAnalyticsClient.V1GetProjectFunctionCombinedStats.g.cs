#nullable enable

namespace Supabase
{
    public partial interface IAnalyticsClient
    {
        /// <summary>
        /// Gets a project's function combined statistics
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="interval"></param>
        /// <param name="functionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.AnalyticsResponse> V1GetProjectFunctionCombinedStatsAsync(
            string @ref,
            global::Supabase.V1GetProjectFunctionCombinedStatsInterval interval,
            string functionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}