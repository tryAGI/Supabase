
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReadOnlyStatusResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("override_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool OverrideEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("override_active_until")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OverrideActiveUntil { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadOnlyStatusResponse" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="overrideEnabled"></param>
        /// <param name="overrideActiveUntil"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReadOnlyStatusResponse(
            bool enabled,
            bool overrideEnabled,
            string overrideActiveUntil)
        {
            this.Enabled = enabled;
            this.OverrideEnabled = overrideEnabled;
            this.OverrideActiveUntil = overrideActiveUntil ?? throw new global::System.ArgumentNullException(nameof(overrideActiveUntil));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadOnlyStatusResponse" /> class.
        /// </summary>
        public ReadOnlyStatusResponse()
        {
        }

    }
}