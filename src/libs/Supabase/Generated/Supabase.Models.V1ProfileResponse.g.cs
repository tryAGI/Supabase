
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1ProfileResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gotrue_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GotrueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary_email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PrimaryEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ProfileResponse" /> class.
        /// </summary>
        /// <param name="gotrueId"></param>
        /// <param name="primaryEmail"></param>
        /// <param name="username"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1ProfileResponse(
            string gotrueId,
            string primaryEmail,
            string username)
        {
            this.GotrueId = gotrueId ?? throw new global::System.ArgumentNullException(nameof(gotrueId));
            this.PrimaryEmail = primaryEmail ?? throw new global::System.ArgumentNullException(nameof(primaryEmail));
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ProfileResponse" /> class.
        /// </summary>
        public V1ProfileResponse()
        {
        }
    }
}