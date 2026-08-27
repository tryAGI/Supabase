
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DiskAutoscaleConfig
    {
        /// <summary>
        /// Growth percentage for disk autoscaling
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("growth_percent")]
        public long? GrowthPercent { get; set; }

        /// <summary>
        /// Minimum increment size for disk autoscaling in GB
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_increment_gb")]
        public long? MinIncrementGb { get; set; }

        /// <summary>
        /// Maximum limit the disk size will grow to in GB
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_size_gb")]
        public long? MaxSizeGb { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiskAutoscaleConfig" /> class.
        /// </summary>
        /// <param name="growthPercent">
        /// Growth percentage for disk autoscaling
        /// </param>
        /// <param name="minIncrementGb">
        /// Minimum increment size for disk autoscaling in GB
        /// </param>
        /// <param name="maxSizeGb">
        /// Maximum limit the disk size will grow to in GB
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiskAutoscaleConfig(
            long? growthPercent,
            long? minIncrementGb,
            long? maxSizeGb)
        {
            this.GrowthPercent = growthPercent;
            this.MinIncrementGb = minIncrementGb;
            this.MaxSizeGb = maxSizeGb;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiskAutoscaleConfig" /> class.
        /// </summary>
        public DiskAutoscaleConfig()
        {
        }

    }
}