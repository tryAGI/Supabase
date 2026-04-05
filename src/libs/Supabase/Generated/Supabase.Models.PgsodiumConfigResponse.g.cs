
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PgsodiumConfigResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("root_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RootKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PgsodiumConfigResponse" /> class.
        /// </summary>
        /// <param name="rootKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PgsodiumConfigResponse(
            string rootKey)
        {
            this.RootKey = rootKey ?? throw new global::System.ArgumentNullException(nameof(rootKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PgsodiumConfigResponse" /> class.
        /// </summary>
        public PgsodiumConfigResponse()
        {
        }
    }
}