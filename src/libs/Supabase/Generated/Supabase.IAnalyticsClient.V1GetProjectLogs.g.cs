#nullable enable

namespace Supabase
{
    public partial interface IAnalyticsClient
    {
        /// <summary>
        /// Gets all project's logs in a single log stream<br/>
        /// Executes an SQL or LQL query on the project's unified logs stream.<br/>
        /// Either the `iso_timestamp_start` and `iso_timestamp_end` parameters must be provided.<br/>
        /// If both are not provided, only the last 1 minute of logs will be queried.<br/>
        /// The timestamp range must be no more than 24 hours and is rounded to the nearest minute. If the range is more than 24 hours, a validation error will be thrown.<br/>
        /// Filter by the `source` column to specify specific log sources, such as edge_logs, postgres_logs, etc.<br/>
        /// Note: SQL must be written in **ClickHouse SQL dialect**.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="sql"></param>
        /// <param name="isoTimestampStart">
        /// Example: 2025-03-01T00:00:00Z
        /// </param>
        /// <param name="isoTimestampEnd">
        /// Example: 2025-03-01T23:59:59Z
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.AnalyticsResponse> V1GetProjectLogsAsync(
            string @ref,
            string? sql = default,
            global::System.DateTime? isoTimestampStart = default,
            global::System.DateTime? isoTimestampEnd = default,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets all project's logs in a single log stream<br/>
        /// Executes an SQL or LQL query on the project's unified logs stream.<br/>
        /// Either the `iso_timestamp_start` and `iso_timestamp_end` parameters must be provided.<br/>
        /// If both are not provided, only the last 1 minute of logs will be queried.<br/>
        /// The timestamp range must be no more than 24 hours and is rounded to the nearest minute. If the range is more than 24 hours, a validation error will be thrown.<br/>
        /// Filter by the `source` column to specify specific log sources, such as edge_logs, postgres_logs, etc.<br/>
        /// Note: SQL must be written in **ClickHouse SQL dialect**.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="sql"></param>
        /// <param name="isoTimestampStart">
        /// Example: 2025-03-01T00:00:00Z
        /// </param>
        /// <param name="isoTimestampEnd">
        /// Example: 2025-03-01T23:59:59Z
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.AutoSDKHttpResponse<global::Supabase.AnalyticsResponse>> V1GetProjectLogsAsResponseAsync(
            string @ref,
            string? sql = default,
            global::System.DateTime? isoTimestampStart = default,
            global::System.DateTime? isoTimestampEnd = default,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}