#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// Updates project's Postgres config
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.PostgresConfigResponse> V1UpdatePostgresConfigAsync(
            string @ref,

            global::Supabase.UpdatePostgresConfigBody request,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates project's Postgres config
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.AutoSDKHttpResponse<global::Supabase.PostgresConfigResponse>> V1UpdatePostgresConfigAsResponseAsync(
            string @ref,

            global::Supabase.UpdatePostgresConfigBody request,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates project's Postgres config
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="effectiveCacheSize"></param>
        /// <param name="logicalDecodingWorkMem"></param>
        /// <param name="maintenanceWorkMem"></param>
        /// <param name="trackActivityQuerySize"></param>
        /// <param name="maxConnections"></param>
        /// <param name="maxLocksPerTransaction"></param>
        /// <param name="maxParallelMaintenanceWorkers"></param>
        /// <param name="maxParallelWorkers"></param>
        /// <param name="maxParallelWorkersPerGather"></param>
        /// <param name="maxReplicationSlots"></param>
        /// <param name="maxSlotWalKeepSize"></param>
        /// <param name="maxStandbyArchiveDelay"></param>
        /// <param name="maxStandbyStreamingDelay"></param>
        /// <param name="maxWalSize"></param>
        /// <param name="maxWalSenders"></param>
        /// <param name="maxWorkerProcesses"></param>
        /// <param name="sessionReplicationRole"></param>
        /// <param name="sharedBuffers"></param>
        /// <param name="statementTimeout">
        /// Default unit: ms
        /// </param>
        /// <param name="trackCommitTimestamp"></param>
        /// <param name="walKeepSize"></param>
        /// <param name="walSenderTimeout">
        /// Default unit: ms
        /// </param>
        /// <param name="workMem"></param>
        /// <param name="checkpointTimeout">
        /// Default unit: s
        /// </param>
        /// <param name="hotStandbyFeedback"></param>
        /// <param name="restartDatabase"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.PostgresConfigResponse> V1UpdatePostgresConfigAsync(
            string @ref,
            string? effectiveCacheSize = default,
            string? logicalDecodingWorkMem = default,
            string? maintenanceWorkMem = default,
            string? trackActivityQuerySize = default,
            int? maxConnections = default,
            int? maxLocksPerTransaction = default,
            int? maxParallelMaintenanceWorkers = default,
            int? maxParallelWorkers = default,
            int? maxParallelWorkersPerGather = default,
            int? maxReplicationSlots = default,
            string? maxSlotWalKeepSize = default,
            string? maxStandbyArchiveDelay = default,
            string? maxStandbyStreamingDelay = default,
            string? maxWalSize = default,
            int? maxWalSenders = default,
            int? maxWorkerProcesses = default,
            global::Supabase.UpdatePostgresConfigBodySessionReplicationRole? sessionReplicationRole = default,
            string? sharedBuffers = default,
            string? statementTimeout = default,
            bool? trackCommitTimestamp = default,
            string? walKeepSize = default,
            string? walSenderTimeout = default,
            string? workMem = default,
            string? checkpointTimeout = default,
            bool? hotStandbyFeedback = default,
            bool? restartDatabase = default,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}