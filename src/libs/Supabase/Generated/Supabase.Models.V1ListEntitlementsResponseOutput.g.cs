
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class V1ListEntitlementsResponseOutput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entitlements")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.V1ListEntitlementsResponseOutputEntitlement> Entitlements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ListEntitlementsResponseOutput" /> class.
        /// </summary>
        /// <param name="entitlements"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1ListEntitlementsResponseOutput(
            global::System.Collections.Generic.IList<global::Supabase.V1ListEntitlementsResponseOutputEntitlement> entitlements)
        {
            this.Entitlements = entitlements ?? throw new global::System.ArgumentNullException(nameof(entitlements));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ListEntitlementsResponseOutput" /> class.
        /// </summary>
        public V1ListEntitlementsResponseOutput()
        {
        }

    }
}