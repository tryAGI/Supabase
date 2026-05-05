
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1BackupsResponseBackup
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_physical_backup")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPhysicalBackup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.V1BackupsResponseBackupStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.V1BackupsResponseBackupStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inserted_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InsertedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1BackupsResponseBackup" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isPhysicalBackup"></param>
        /// <param name="status"></param>
        /// <param name="insertedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1BackupsResponseBackup(
            int id,
            bool isPhysicalBackup,
            global::Supabase.V1BackupsResponseBackupStatus status,
            string insertedAt)
        {
            this.Id = id;
            this.IsPhysicalBackup = isPhysicalBackup;
            this.Status = status;
            this.InsertedAt = insertedAt ?? throw new global::System.ArgumentNullException(nameof(insertedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1BackupsResponseBackup" /> class.
        /// </summary>
        public V1BackupsResponseBackup()
        {
        }
    }
}