#nullable enable

namespace Supabase
{
    public partial interface IAnalyticsClient
    {
        /// <summary>
        /// Gets project's usage api counts
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="interval"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.V1GetUsageApiCountResponse> V1GetProjectUsageApiCountAsync(
            string @ref,
            global::Supabase.V1GetProjectUsageApiCountInterval? interval = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}