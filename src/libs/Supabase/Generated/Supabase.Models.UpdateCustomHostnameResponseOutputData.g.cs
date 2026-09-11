
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateCustomHostnameResponseOutputData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.JsonValueOutput> Errors { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.JsonValueOutput> Messages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.UpdateCustomHostnameResponseOutputDataResult Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomHostnameResponseOutputData" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="errors"></param>
        /// <param name="messages"></param>
        /// <param name="result"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCustomHostnameResponseOutputData(
            bool success,
            global::System.Collections.Generic.IList<global::Supabase.JsonValueOutput> errors,
            global::System.Collections.Generic.IList<global::Supabase.JsonValueOutput> messages,
            global::Supabase.UpdateCustomHostnameResponseOutputDataResult result)
        {
            this.Success = success;
            this.Errors = errors ?? throw new global::System.ArgumentNullException(nameof(errors));
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomHostnameResponseOutputData" /> class.
        /// </summary>
        public UpdateCustomHostnameResponseOutputData()
        {
        }

    }
}