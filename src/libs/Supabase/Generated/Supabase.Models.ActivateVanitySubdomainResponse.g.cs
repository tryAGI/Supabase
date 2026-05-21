
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActivateVanitySubdomainResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomDomain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivateVanitySubdomainResponse" /> class.
        /// </summary>
        /// <param name="customDomain"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivateVanitySubdomainResponse(
            string customDomain)
        {
            this.CustomDomain = customDomain ?? throw new global::System.ArgumentNullException(nameof(customDomain));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivateVanitySubdomainResponse" /> class.
        /// </summary>
        public ActivateVanitySubdomainResponse()
        {
        }

    }
}