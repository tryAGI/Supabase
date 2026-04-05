
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1BackupsResponsePhysicalBackupData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("earliest_physical_backup_date_unix")]
        public int? EarliestPhysicalBackupDateUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_physical_backup_date_unix")]
        public int? LatestPhysicalBackupDateUnix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1BackupsResponsePhysicalBackupData" /> class.
        /// </summary>
        /// <param name="earliestPhysicalBackupDateUnix"></param>
        /// <param name="latestPhysicalBackupDateUnix"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1BackupsResponsePhysicalBackupData(
            int? earliestPhysicalBackupDateUnix,
            int? latestPhysicalBackupDateUnix)
        {
            this.EarliestPhysicalBackupDateUnix = earliestPhysicalBackupDateUnix;
            this.LatestPhysicalBackupDateUnix = latestPhysicalBackupDateUnix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1BackupsResponsePhysicalBackupData" /> class.
        /// </summary>
        public V1BackupsResponsePhysicalBackupData()
        {
        }
    }
}