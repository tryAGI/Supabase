
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1GetUsageApiCountResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::System.Collections.Generic.IList<global::Supabase.V1GetUsageApiCountResponseResultItem>? Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.OneOfJsonConverter<string, global::Supabase.V1GetUsageApiCountResponseError>))]
        public global::Supabase.OneOf<string, global::Supabase.V1GetUsageApiCountResponseError>? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1GetUsageApiCountResponse" /> class.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1GetUsageApiCountResponse(
            global::System.Collections.Generic.IList<global::Supabase.V1GetUsageApiCountResponseResultItem>? result,
            global::Supabase.OneOf<string, global::Supabase.V1GetUsageApiCountResponseError>? error)
        {
            this.Result = result;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1GetUsageApiCountResponse" /> class.
        /// </summary>
        public V1GetUsageApiCountResponse()
        {
        }

    }
}