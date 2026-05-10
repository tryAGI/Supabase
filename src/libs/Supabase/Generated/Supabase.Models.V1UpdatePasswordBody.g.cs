
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"password":"correct-horse-battery-staple"}
    /// </summary>
    public sealed partial class V1UpdatePasswordBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Password { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1UpdatePasswordBody" /> class.
        /// </summary>
        /// <param name="password"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1UpdatePasswordBody(
            string password)
        {
            this.Password = password ?? throw new global::System.ArgumentNullException(nameof(password));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1UpdatePasswordBody" /> class.
        /// </summary>
        public V1UpdatePasswordBody()
        {
        }

    }
}