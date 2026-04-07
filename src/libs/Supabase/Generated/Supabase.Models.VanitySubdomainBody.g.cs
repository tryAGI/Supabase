
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"vanity_subdomain":"acme-prod"}
    /// </summary>
    public sealed partial class VanitySubdomainBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vanity_subdomain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VanitySubdomain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VanitySubdomainBody" /> class.
        /// </summary>
        /// <param name="vanitySubdomain"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VanitySubdomainBody(
            string vanitySubdomain)
        {
            this.VanitySubdomain = vanitySubdomain ?? throw new global::System.ArgumentNullException(nameof(vanitySubdomain));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VanitySubdomainBody" /> class.
        /// </summary>
        public VanitySubdomainBody()
        {
        }
    }
}