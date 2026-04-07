#nullable enable

namespace Supabase
{
    public partial interface IAnalyticsClient
    {
        /// <summary>
        /// Gets project's usage api requests count
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.V1GetUsageApiRequestsCountResponse> V1GetProjectUsageRequestCountAsync(
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}