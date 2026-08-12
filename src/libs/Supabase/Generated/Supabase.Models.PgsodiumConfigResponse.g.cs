
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"root_key":"0123456789abcdef0123456789abcdef0123456789abcdef0123456789abcdef"}
    /// </summary>
    public sealed partial class PgsodiumConfigResponse
    {
        /// <summary>
        /// The pgsodium root key: 32 bytes, hex-encoded (64 characters).
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
        /// <param name="rootKey">
        /// The pgsodium root key: 32 bytes, hex-encoded (64 characters).
        /// </param>
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