
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatus
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initiated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InitiatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_status_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LatestStatusAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusErrorJsonConverter))]
        public global::Supabase.DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusError? Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusProgressJsonConverter))]
        public global::Supabase.DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusProgress? Progress { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatus" /> class.
        /// </summary>
        /// <param name="initiatedAt"></param>
        /// <param name="latestStatusAt"></param>
        /// <param name="targetVersion"></param>
        /// <param name="status"></param>
        /// <param name="error"></param>
        /// <param name="progress"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatus(
            string initiatedAt,
            string latestStatusAt,
            string targetVersion,
            double status,
            global::Supabase.DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusError? error,
            global::Supabase.DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusProgress? progress)
        {
            this.InitiatedAt = initiatedAt ?? throw new global::System.ArgumentNullException(nameof(initiatedAt));
            this.LatestStatusAt = latestStatusAt ?? throw new global::System.ArgumentNullException(nameof(latestStatusAt));
            this.TargetVersion = targetVersion ?? throw new global::System.ArgumentNullException(nameof(targetVersion));
            this.Error = error;
            this.Progress = progress;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatus" /> class.
        /// </summary>
        public DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatus()
        {
        }

    }
}