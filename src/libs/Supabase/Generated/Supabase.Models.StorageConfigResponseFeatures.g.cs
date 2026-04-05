
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StorageConfigResponseFeatures
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageTransformation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.StorageConfigResponseFeaturesImageTransformation ImageTransformation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3Protocol")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.StorageConfigResponseFeaturesS3Protocol S3Protocol { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icebergCatalog")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.StorageConfigResponseFeaturesIcebergCatalog IcebergCatalog { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorBuckets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.StorageConfigResponseFeaturesVectorBuckets VectorBuckets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageConfigResponseFeatures" /> class.
        /// </summary>
        /// <param name="imageTransformation"></param>
        /// <param name="s3Protocol"></param>
        /// <param name="icebergCatalog"></param>
        /// <param name="vectorBuckets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StorageConfigResponseFeatures(
            global::Supabase.StorageConfigResponseFeaturesImageTransformation imageTransformation,
            global::Supabase.StorageConfigResponseFeaturesS3Protocol s3Protocol,
            global::Supabase.StorageConfigResponseFeaturesIcebergCatalog icebergCatalog,
            global::Supabase.StorageConfigResponseFeaturesVectorBuckets vectorBuckets)
        {
            this.ImageTransformation = imageTransformation ?? throw new global::System.ArgumentNullException(nameof(imageTransformation));
            this.S3Protocol = s3Protocol ?? throw new global::System.ArgumentNullException(nameof(s3Protocol));
            this.IcebergCatalog = icebergCatalog ?? throw new global::System.ArgumentNullException(nameof(icebergCatalog));
            this.VectorBuckets = vectorBuckets ?? throw new global::System.ArgumentNullException(nameof(vectorBuckets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageConfigResponseFeatures" /> class.
        /// </summary>
        public StorageConfigResponseFeatures()
        {
        }
    }
}