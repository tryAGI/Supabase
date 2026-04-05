
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StorageConfigResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileSizeLimit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long FileSizeLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("features")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.StorageConfigResponseFeatures Features { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.StorageConfigResponseCapabilities Capabilities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.StorageConfigResponseExternal External { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("migrationVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MigrationVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("databasePoolMode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatabasePoolMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageConfigResponse" /> class.
        /// </summary>
        /// <param name="fileSizeLimit"></param>
        /// <param name="features"></param>
        /// <param name="capabilities"></param>
        /// <param name="external"></param>
        /// <param name="migrationVersion"></param>
        /// <param name="databasePoolMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StorageConfigResponse(
            long fileSizeLimit,
            global::Supabase.StorageConfigResponseFeatures features,
            global::Supabase.StorageConfigResponseCapabilities capabilities,
            global::Supabase.StorageConfigResponseExternal external,
            string migrationVersion,
            string databasePoolMode)
        {
            this.FileSizeLimit = fileSizeLimit;
            this.Features = features ?? throw new global::System.ArgumentNullException(nameof(features));
            this.Capabilities = capabilities ?? throw new global::System.ArgumentNullException(nameof(capabilities));
            this.External = external ?? throw new global::System.ArgumentNullException(nameof(external));
            this.MigrationVersion = migrationVersion ?? throw new global::System.ArgumentNullException(nameof(migrationVersion));
            this.DatabasePoolMode = databasePoolMode ?? throw new global::System.ArgumentNullException(nameof(databasePoolMode));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageConfigResponse" /> class.
        /// </summary>
        public StorageConfigResponse()
        {
        }
    }
}