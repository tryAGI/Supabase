
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BranchRestoreResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.BranchRestoreResponseMessageJsonConverter))]
        public global::Supabase.BranchRestoreResponseMessage Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchRestoreResponse" /> class.
        /// </summary>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchRestoreResponse(
            global::Supabase.BranchRestoreResponseMessage message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchRestoreResponse" /> class.
        /// </summary>
        public BranchRestoreResponse()
        {
        }

    }
}