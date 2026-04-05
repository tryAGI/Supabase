
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostgresConfigResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_cache_size")]
        public string? EffectiveCacheSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logical_decoding_work_mem")]
        public string? LogicalDecodingWorkMem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maintenance_work_mem")]
        public string? MaintenanceWorkMem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_activity_query_size")]
        public string? TrackActivityQuerySize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_connections")]
        public int? MaxConnections { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_locks_per_transaction")]
        public int? MaxLocksPerTransaction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_parallel_maintenance_workers")]
        public int? MaxParallelMaintenanceWorkers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_parallel_workers")]
        public int? MaxParallelWorkers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_parallel_workers_per_gather")]
        public int? MaxParallelWorkersPerGather { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_replication_slots")]
        public int? MaxReplicationSlots { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_slot_wal_keep_size")]
        public string? MaxSlotWalKeepSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_standby_archive_delay")]
        public string? MaxStandbyArchiveDelay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_standby_streaming_delay")]
        public string? MaxStandbyStreamingDelay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_wal_size")]
        public string? MaxWalSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_wal_senders")]
        public int? MaxWalSenders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_worker_processes")]
        public int? MaxWorkerProcesses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_replication_role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.PostgresConfigResponseSessionReplicationRoleJsonConverter))]
        public global::Supabase.PostgresConfigResponseSessionReplicationRole? SessionReplicationRole { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shared_buffers")]
        public string? SharedBuffers { get; set; }

        /// <summary>
        /// Default unit: ms
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statement_timeout")]
        public string? StatementTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_commit_timestamp")]
        public bool? TrackCommitTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wal_keep_size")]
        public string? WalKeepSize { get; set; }

        /// <summary>
        /// Default unit: ms
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wal_sender_timeout")]
        public string? WalSenderTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("work_mem")]
        public string? WorkMem { get; set; }

        /// <summary>
        /// Default unit: s
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint_timeout")]
        public string? CheckpointTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hot_standby_feedback")]
        public bool? HotStandbyFeedback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostgresConfigResponse" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostgresConfigResponse(
            string? effectiveCacheSize,
            string? logicalDecodingWorkMem,
            string? maintenanceWorkMem,
            string? trackActivityQuerySize,
            int? maxConnections,
            int? maxLocksPerTransaction,
            int? maxParallelMaintenanceWorkers,
            int? maxParallelWorkers,
            int? maxParallelWorkersPerGather,
            int? maxReplicationSlots,
            string? maxSlotWalKeepSize,
            string? maxStandbyArchiveDelay,
            string? maxStandbyStreamingDelay,
            string? maxWalSize,
            int? maxWalSenders,
            int? maxWorkerProcesses,
            global::Supabase.PostgresConfigResponseSessionReplicationRole? sessionReplicationRole,
            string? sharedBuffers,
            string? statementTimeout,
            bool? trackCommitTimestamp,
            string? walKeepSize,
            string? walSenderTimeout,
            string? workMem,
            string? checkpointTimeout,
            bool? hotStandbyFeedback)
        {
            this.EffectiveCacheSize = effectiveCacheSize;
            this.LogicalDecodingWorkMem = logicalDecodingWorkMem;
            this.MaintenanceWorkMem = maintenanceWorkMem;
            this.TrackActivityQuerySize = trackActivityQuerySize;
            this.MaxConnections = maxConnections;
            this.MaxLocksPerTransaction = maxLocksPerTransaction;
            this.MaxParallelMaintenanceWorkers = maxParallelMaintenanceWorkers;
            this.MaxParallelWorkers = maxParallelWorkers;
            this.MaxParallelWorkersPerGather = maxParallelWorkersPerGather;
            this.MaxReplicationSlots = maxReplicationSlots;
            this.MaxSlotWalKeepSize = maxSlotWalKeepSize;
            this.MaxStandbyArchiveDelay = maxStandbyArchiveDelay;
            this.MaxStandbyStreamingDelay = maxStandbyStreamingDelay;
            this.MaxWalSize = maxWalSize;
            this.MaxWalSenders = maxWalSenders;
            this.MaxWorkerProcesses = maxWorkerProcesses;
            this.SessionReplicationRole = sessionReplicationRole;
            this.SharedBuffers = sharedBuffers;
            this.StatementTimeout = statementTimeout;
            this.TrackCommitTimestamp = trackCommitTimestamp;
            this.WalKeepSize = walKeepSize;
            this.WalSenderTimeout = walSenderTimeout;
            this.WorkMem = workMem;
            this.CheckpointTimeout = checkpointTimeout;
            this.HotStandbyFeedback = hotStandbyFeedback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostgresConfigResponse" /> class.
        /// </summary>
        public PostgresConfigResponse()
        {
        }
    }
}