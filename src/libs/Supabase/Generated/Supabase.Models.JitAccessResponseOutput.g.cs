
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JitAccessResponseOutput
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
        public required global::System.Collections.Generic.IList<global::Supabase.JitAccessResponseOutputUserRole> UserRoles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JitAccessResponseOutput" /> class.
        /// </summary>
        /// <param name="userRoles"></param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JitAccessResponseOutput(
            global::System.Collections.Generic.IList<global::Supabase.JitAccessResponseOutputUserRole> userRoles,
            global::System.Guid? userId)
        {
            this.UserId = userId;
            this.UserRoles = userRoles ?? throw new global::System.ArgumentNullException(nameof(userRoles));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JitAccessResponseOutput" /> class.
        /// </summary>
        public JitAccessResponseOutput()
        {
        }

    }
}