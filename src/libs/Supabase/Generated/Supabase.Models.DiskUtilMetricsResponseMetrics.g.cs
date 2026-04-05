
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DiskUtilMetricsResponseMetrics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fs_size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FsSizeBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fs_avail_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FsAvailBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fs_used_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FsUsedBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiskUtilMetricsResponseMetrics" /> class.
        /// </summary>
        /// <param name="fsSizeBytes"></param>
        /// <param name="fsAvailBytes"></param>
        /// <param name="fsUsedBytes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiskUtilMetricsResponseMetrics(
            double fsSizeBytes,
            double fsAvailBytes,
            double fsUsedBytes)
        {
            this.FsSizeBytes = fsSizeBytes;
            this.FsAvailBytes = fsAvailBytes;
            this.FsUsedBytes = fsUsedBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiskUtilMetricsResponseMetrics" /> class.
        /// </summary>
        public DiskUtilMetricsResponseMetrics()
        {
        }
    }
}