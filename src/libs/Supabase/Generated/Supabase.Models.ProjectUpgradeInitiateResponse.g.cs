
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectUpgradeInitiateResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracking_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrackingId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpgradeInitiateResponse" /> class.
        /// </summary>
        /// <param name="trackingId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectUpgradeInitiateResponse(
            string trackingId)
        {
            this.TrackingId = trackingId ?? throw new global::System.ArgumentNullException(nameof(trackingId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpgradeInitiateResponse" /> class.
        /// </summary>
        public ProjectUpgradeInitiateResponse()
        {
        }
    }
}