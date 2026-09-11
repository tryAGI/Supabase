
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SslEnforcementResponseOutput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentConfig")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.SslEnforcementResponseOutputCurrentConfig CurrentConfig { get; set; }

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
        /// Initializes a new instance of the <see cref="SslEnforcementResponseOutput" /> class.
        /// </summary>
        /// <param name="currentConfig"></param>
        /// <param name="appliedSuccessfully"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SslEnforcementResponseOutput(
            global::Supabase.SslEnforcementResponseOutputCurrentConfig currentConfig,
            bool appliedSuccessfully)
        {
            this.CurrentConfig = currentConfig ?? throw new global::System.ArgumentNullException(nameof(currentConfig));
            this.AppliedSuccessfully = appliedSuccessfully;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SslEnforcementResponseOutput" /> class.
        /// </summary>
        public SslEnforcementResponseOutput()
        {
        }

    }
}