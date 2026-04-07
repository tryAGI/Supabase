
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"add":{"dbAllowedCidrs":["203.0.113.0/24"]},"remove":{"dbAllowedCidrs":["198.51.100.0/24"]}}
    /// </summary>
    public sealed partial class NetworkRestrictionsPatchRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add")]
        public global::Supabase.NetworkRestrictionsPatchRequestAdd? Add { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove")]
        public global::Supabase.NetworkRestrictionsPatchRequestRemove? Remove { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkRestrictionsPatchRequest" /> class.
        /// </summary>
        /// <param name="add"></param>
        /// <param name="remove"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NetworkRestrictionsPatchRequest(
            global::Supabase.NetworkRestrictionsPatchRequestAdd? add,
            global::Supabase.NetworkRestrictionsPatchRequestRemove? remove)
        {
            this.Add = add;
            this.Remove = remove;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkRestrictionsPatchRequest" /> class.
        /// </summary>
        public NetworkRestrictionsPatchRequest()
        {
        }
    }
}