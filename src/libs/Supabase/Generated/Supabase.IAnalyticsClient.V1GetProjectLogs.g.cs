#nullable enable

namespace Supabase
{
    public partial interface IAnalyticsClient
    {
        /// <summary>
        /// Gets project's logs<br/>
        /// Executes a SQL query on the project's logs.<br/>
        /// Either the `iso_timestamp_start` and `iso_timestamp_end` parameters must be provided.<br/>
        /// If both are not provided, only the last 1 minute of logs will be queried.<br/>
        /// The timestamp range must be no more than 24 hours and is rounded to the nearest minute. If the range is more than 24 hours, a validation error will be thrown.<br/>
        /// Note: Unless the `sql` parameter is provided, only edge_logs will be queried. See the [log query docs](/docs/guides/telemetry/logs?queryGroups=product&amp;product=postgres&amp;queryGroups=source&amp;source=edge_logs#querying-with-the-logs-explorer:~:text=logs%20from%20the-,Sources,-drop%2Ddown%3A) for all available sources. 
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="sql"></param>
        /// <param name="isoTimestampStart"></param>
        /// <param name="isoTimestampEnd"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.AnalyticsResponse> V1GetProjectLogsAsync(
            string @ref,
            string? sql = default,
            global::System.DateTime? isoTimestampStart = default,
            global::System.DateTime? isoTimestampEnd = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}