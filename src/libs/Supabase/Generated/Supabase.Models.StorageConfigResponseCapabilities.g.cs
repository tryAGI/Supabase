
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StorageConfigResponseCapabilities
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("list_v2")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ListV2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iceberg_catalog")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IcebergCatalog { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageConfigResponseCapabilities" /> class.
        /// </summary>
        /// <param name="listV2"></param>
        /// <param name="icebergCatalog"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StorageConfigResponseCapabilities(
            bool listV2,
            bool icebergCatalog)
        {
            this.ListV2 = listV2;
            this.IcebergCatalog = icebergCatalog;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageConfigResponseCapabilities" /> class.
        /// </summary>
        public StorageConfigResponseCapabilities()
        {
        }

    }
}