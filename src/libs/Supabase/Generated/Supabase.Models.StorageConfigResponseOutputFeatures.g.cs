
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StorageConfigResponseOutputFeatures
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageTransformation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.StorageConfigResponseOutputFeaturesImageTransformation ImageTransformation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3Protocol")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.StorageConfigResponseOutputFeaturesS3Protocol S3Protocol { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purgeCache")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.StorageConfigResponseOutputFeaturesPurgeCache PurgeCache { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icebergCatalog")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.StorageConfigResponseOutputFeaturesIcebergCatalog IcebergCatalog { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorBuckets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.StorageConfigResponseOutputFeaturesVectorBuckets VectorBuckets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageConfigResponseOutputFeatures" /> class.
        /// </summary>
        /// <param name="imageTransformation"></param>
        /// <param name="s3Protocol"></param>
        /// <param name="purgeCache"></param>
        /// <param name="icebergCatalog"></param>
        /// <param name="vectorBuckets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StorageConfigResponseOutputFeatures(
            global::Supabase.StorageConfigResponseOutputFeaturesImageTransformation imageTransformation,
            global::Supabase.StorageConfigResponseOutputFeaturesS3Protocol s3Protocol,
            global::Supabase.StorageConfigResponseOutputFeaturesPurgeCache purgeCache,
            global::Supabase.StorageConfigResponseOutputFeaturesIcebergCatalog icebergCatalog,
            global::Supabase.StorageConfigResponseOutputFeaturesVectorBuckets vectorBuckets)
        {
            this.ImageTransformation = imageTransformation ?? throw new global::System.ArgumentNullException(nameof(imageTransformation));
            this.S3Protocol = s3Protocol ?? throw new global::System.ArgumentNullException(nameof(s3Protocol));
            this.PurgeCache = purgeCache ?? throw new global::System.ArgumentNullException(nameof(purgeCache));
            this.IcebergCatalog = icebergCatalog ?? throw new global::System.ArgumentNullException(nameof(icebergCatalog));
            this.VectorBuckets = vectorBuckets ?? throw new global::System.ArgumentNullException(nameof(vectorBuckets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageConfigResponseOutputFeatures" /> class.
        /// </summary>
        public StorageConfigResponseOutputFeatures()
        {
        }

    }
}