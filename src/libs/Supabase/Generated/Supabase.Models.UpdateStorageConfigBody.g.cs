
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateStorageConfigBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileSizeLimit")]
        public long? FileSizeLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("features")]
        public global::Supabase.UpdateStorageConfigBodyFeatures? Features { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external")]
        public global::Supabase.UpdateStorageConfigBodyExternal? External { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStorageConfigBody" /> class.
        /// </summary>
        /// <param name="fileSizeLimit"></param>
        /// <param name="features"></param>
        /// <param name="external"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateStorageConfigBody(
            long? fileSizeLimit,
            global::Supabase.UpdateStorageConfigBodyFeatures? features,
            global::Supabase.UpdateStorageConfigBodyExternal? external)
        {
            this.FileSizeLimit = fileSizeLimit;
            this.Features = features;
            this.External = external;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStorageConfigBody" /> class.
        /// </summary>
        public UpdateStorageConfigBody()
        {
        }
    }
}