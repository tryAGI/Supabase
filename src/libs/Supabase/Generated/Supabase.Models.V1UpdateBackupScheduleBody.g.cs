
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"schedule_for":"04:00:00"}
    /// </summary>
    public sealed partial class V1UpdateBackupScheduleBody
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1UpdateBackupScheduleBody" /> class.
        /// </summary>
        /// <param name="scheduleFor">
        /// Time of day to schedule daily backups, in UTC. Format: HH:MM:SS.<br/>
        /// Example: 04:00:00
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1UpdateBackupScheduleBody(
            string scheduleFor)
        {
            this.ScheduleFor = scheduleFor ?? throw new global::System.ArgumentNullException(nameof(scheduleFor));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1UpdateBackupScheduleBody" /> class.
        /// </summary>
        public V1UpdateBackupScheduleBody()
        {
        }

    }
}