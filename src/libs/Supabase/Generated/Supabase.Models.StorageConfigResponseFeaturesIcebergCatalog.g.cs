
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StorageConfigResponseFeaturesIcebergCatalog
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxNamespaces")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxNamespaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxTables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxTables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxCatalogs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxCatalogs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageConfigResponseFeaturesIcebergCatalog" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="maxNamespaces"></param>
        /// <param name="maxTables"></param>
        /// <param name="maxCatalogs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StorageConfigResponseFeaturesIcebergCatalog(
            bool enabled,
            int maxNamespaces,
            int maxTables,
            int maxCatalogs)
        {
            this.Enabled = enabled;
            this.MaxNamespaces = maxNamespaces;
            this.MaxTables = maxTables;
            this.MaxCatalogs = maxCatalogs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageConfigResponseFeaturesIcebergCatalog" /> class.
        /// </summary>
        public StorageConfigResponseFeaturesIcebergCatalog()
        {
        }

    }
}