
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1BackupScheduleResponse
    {
        /// <summary>
        /// Time of day to schedule daily backups, in UTC. Format: HH:MM:SS.<br/>
        /// Example: 04:00:00
        /// </summary>
        /// <example>04:00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule_for")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ScheduleFor { get; set; }

        /// <summary>
        /// Timestamp of when the backup schedule was last updated.<br/>
        /// Example: 2026-05-04T14:40:44+00:00
        /// </summary>
        /// <example>2026-05-04T14:40:44+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1BackupScheduleResponse" /> class.
        /// </summary>
        /// <param name="scheduleFor">
        /// Time of day to schedule daily backups, in UTC. Format: HH:MM:SS.<br/>
        /// Example: 04:00:00
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp of when the backup schedule was last updated.<br/>
        /// Example: 2026-05-04T14:40:44+00:00
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1BackupScheduleResponse(
            string scheduleFor,
            global::System.DateTime updatedAt)
        {
            this.ScheduleFor = scheduleFor ?? throw new global::System.ArgumentNullException(nameof(scheduleFor));
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1BackupScheduleResponse" /> class.
        /// </summary>
        public V1BackupScheduleResponse()
        {
        }

    }
}