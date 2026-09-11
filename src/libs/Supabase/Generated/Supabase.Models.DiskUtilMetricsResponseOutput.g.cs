
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DiskUtilMetricsResponseOutput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.DiskUtilMetricsResponseOutputMetrics Metrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiskUtilMetricsResponseOutput" /> class.
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="metrics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiskUtilMetricsResponseOutput(
            string timestamp,
            global::Supabase.DiskUtilMetricsResponseOutputMetrics metrics)
        {
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.Metrics = metrics ?? throw new global::System.ArgumentNullException(nameof(metrics));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiskUtilMetricsResponseOutput" /> class.
        /// </summary>
        public DiskUtilMetricsResponseOutput()
        {
        }

    }
}