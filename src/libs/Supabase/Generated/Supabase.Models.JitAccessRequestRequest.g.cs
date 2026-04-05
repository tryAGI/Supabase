
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JitAccessRequestRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.JitAccessRequestRequestStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.JitAccessRequestRequestState State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JitAccessRequestRequest" /> class.
        /// </summary>
        /// <param name="state"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JitAccessRequestRequest(
            global::Supabase.JitAccessRequestRequestState state)
        {
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JitAccessRequestRequest" /> class.
        /// </summary>
        public JitAccessRequestRequest()
        {
        }
    }
}