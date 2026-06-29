
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JitAccessResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_roles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.JitAccessResponseUserRole> UserRoles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JitAccessResponse" /> class.
        /// </summary>
        /// <param name="userRoles"></param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JitAccessResponse(
            global::System.Collections.Generic.IList<global::Supabase.JitAccessResponseUserRole> userRoles,
            global::System.Guid? userId)
        {
            this.UserId = userId;
            this.UserRoles = userRoles ?? throw new global::System.ArgumentNullException(nameof(userRoles));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JitAccessResponse" /> class.
        /// </summary>
        public JitAccessResponse()
        {
        }

    }
}