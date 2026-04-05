
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateStorageConfigBodyFeatures
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageTransformation")]
        public global::Supabase.UpdateStorageConfigBodyFeaturesImageTransformation? ImageTransformation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3Protocol")]
        public global::Supabase.UpdateStorageConfigBodyFeaturesS3Protocol? S3Protocol { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icebergCatalog")]
        public global::Supabase.UpdateStorageConfigBodyFeaturesIcebergCatalog? IcebergCatalog { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorBuckets")]
        public global::Supabase.UpdateStorageConfigBodyFeaturesVectorBuckets? VectorBuckets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStorageConfigBodyFeatures" /> class.
        /// </summary>
        /// <param name="imageTransformation"></param>
        /// <param name="s3Protocol"></param>
        /// <param name="icebergCatalog"></param>
        /// <param name="vectorBuckets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateStorageConfigBodyFeatures(
            global::Supabase.UpdateStorageConfigBodyFeaturesImageTransformation? imageTransformation,
            global::Supabase.UpdateStorageConfigBodyFeaturesS3Protocol? s3Protocol,
            global::Supabase.UpdateStorageConfigBodyFeaturesIcebergCatalog? icebergCatalog,
            global::Supabase.UpdateStorageConfigBodyFeaturesVectorBuckets? vectorBuckets)
        {
            this.ImageTransformation = imageTransformation;
            this.S3Protocol = s3Protocol;
            this.IcebergCatalog = icebergCatalog;
            this.VectorBuckets = vectorBuckets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStorageConfigBodyFeatures" /> class.
        /// </summary>
        public UpdateStorageConfigBodyFeatures()
        {
        }
    }
}