
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SslEnforcementResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentConfig")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.SslEnforcementResponseCurrentConfig CurrentConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appliedSuccessfully")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AppliedSuccessfully { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SslEnforcementResponse" /> class.
        /// </summary>
        /// <param name="currentConfig"></param>
        /// <param name="appliedSuccessfully"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SslEnforcementResponse(
            global::Supabase.SslEnforcementResponseCurrentConfig currentConfig,
            bool appliedSuccessfully)
        {
            this.CurrentConfig = currentConfig ?? throw new global::System.ArgumentNullException(nameof(currentConfig));
            this.AppliedSuccessfully = appliedSuccessfully;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SslEnforcementResponse" /> class.
        /// </summary>
        public SslEnforcementResponse()
        {
        }
    }
}