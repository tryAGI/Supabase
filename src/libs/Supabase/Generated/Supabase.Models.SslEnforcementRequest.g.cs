
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SslEnforcementRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestedConfig")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.SslEnforcementRequestRequestedConfig RequestedConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SslEnforcementRequest" /> class.
        /// </summary>
        /// <param name="requestedConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SslEnforcementRequest(
            global::Supabase.SslEnforcementRequestRequestedConfig requestedConfig)
        {
            this.RequestedConfig = requestedConfig ?? throw new global::System.ArgumentNullException(nameof(requestedConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SslEnforcementRequest" /> class.
        /// </summary>
        public SslEnforcementRequest()
        {
        }
    }
}