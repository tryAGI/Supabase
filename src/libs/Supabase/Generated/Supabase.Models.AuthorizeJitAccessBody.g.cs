
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"role":"postgres","rhost":"203.0.113.10"}
    /// </summary>
    public sealed partial class AuthorizeJitAccessBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rhost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Rhost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizeJitAccessBody" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="rhost"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthorizeJitAccessBody(
            string role,
            string rhost)
        {
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.Rhost = rhost ?? throw new global::System.ArgumentNullException(nameof(rhost));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizeJitAccessBody" /> class.
        /// </summary>
        public AuthorizeJitAccessBody()
        {
        }

    }
}