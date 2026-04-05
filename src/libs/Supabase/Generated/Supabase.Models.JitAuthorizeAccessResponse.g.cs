
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JitAuthorizeAccessResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.JitAuthorizeAccessResponseUserRole UserRole { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JitAuthorizeAccessResponse" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userRole"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JitAuthorizeAccessResponse(
            global::System.Guid userId,
            global::Supabase.JitAuthorizeAccessResponseUserRole userRole)
        {
            this.UserId = userId;
            this.UserRole = userRole ?? throw new global::System.ArgumentNullException(nameof(userRole));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JitAuthorizeAccessResponse" /> class.
        /// </summary>
        public JitAuthorizeAccessResponse()
        {
        }
    }
}