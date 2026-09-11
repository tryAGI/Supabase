
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StorageConfigResponseOutput
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
        public required global::Supabase.StorageConfigResponseOutputFeatures Features { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.StorageConfigResponseOutputCapabilities Capabilities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.StorageConfigResponseOutputExternal External { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("migrationVersion")]
        public string? MigrationVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageConfigResponseOutput" /> class.
        /// </summary>
        /// <param name="fileSizeLimit"></param>
        /// <param name="features"></param>
        /// <param name="capabilities"></param>
        /// <param name="external"></param>
        /// <param name="migrationVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StorageConfigResponseOutput(
            long fileSizeLimit,
            global::Supabase.StorageConfigResponseOutputFeatures features,
            global::Supabase.StorageConfigResponseOutputCapabilities capabilities,
            global::Supabase.StorageConfigResponseOutputExternal external,
            string? migrationVersion)
        {
            this.FileSizeLimit = fileSizeLimit;
            this.Features = features ?? throw new global::System.ArgumentNullException(nameof(features));
            this.Capabilities = capabilities ?? throw new global::System.ArgumentNullException(nameof(capabilities));
            this.External = external ?? throw new global::System.ArgumentNullException(nameof(external));
            this.MigrationVersion = migrationVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageConfigResponseOutput" /> class.
        /// </summary>
        public StorageConfigResponseOutput()
        {
        }

    }
}