
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class V1BackupsResponseOutput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("walg_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool WalgEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pitr_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PitrEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backups")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.V1BackupsResponseOutputBackup> Backups { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("physical_backup_data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.V1BackupsResponseOutputPhysicalBackupData PhysicalBackupData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1BackupsResponseOutput" /> class.
        /// </summary>
        /// <param name="region"></param>
        /// <param name="walgEnabled"></param>
        /// <param name="pitrEnabled"></param>
        /// <param name="backups"></param>
        /// <param name="physicalBackupData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1BackupsResponseOutput(
            string region,
            bool walgEnabled,
            bool pitrEnabled,
            global::System.Collections.Generic.IList<global::Supabase.V1BackupsResponseOutputBackup> backups,
            global::Supabase.V1BackupsResponseOutputPhysicalBackupData physicalBackupData)
        {
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.WalgEnabled = walgEnabled;
            this.PitrEnabled = pitrEnabled;
            this.Backups = backups ?? throw new global::System.ArgumentNullException(nameof(backups));
            this.PhysicalBackupData = physicalBackupData ?? throw new global::System.ArgumentNullException(nameof(physicalBackupData));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1BackupsResponseOutput" /> class.
        /// </summary>
        public V1BackupsResponseOutput()
        {
        }

    }
}