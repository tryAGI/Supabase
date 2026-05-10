
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StorageConfigResponseFeaturesVectorBuckets
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
        [global::System.Text.Json.Serialization.JsonPropertyName("maxBuckets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxBuckets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxIndexes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxIndexes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageConfigResponseFeaturesVectorBuckets" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="maxBuckets"></param>
        /// <param name="maxIndexes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StorageConfigResponseFeaturesVectorBuckets(
            bool enabled,
            int maxBuckets,
            int maxIndexes)
        {
            this.Enabled = enabled;
            this.MaxBuckets = maxBuckets;
            this.MaxIndexes = maxIndexes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageConfigResponseFeaturesVectorBuckets" /> class.
        /// </summary>
        public StorageConfigResponseFeaturesVectorBuckets()
        {
        }

    }
}