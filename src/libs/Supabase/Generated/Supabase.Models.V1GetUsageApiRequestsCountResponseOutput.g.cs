
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class V1GetUsageApiRequestsCountResponseOutput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::System.Collections.Generic.IList<global::Supabase.V1GetUsageApiRequestsCountResponseOutputResultItem>? Result { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.AnyOfJsonConverter<string, global::Supabase.V1GetUsageApiRequestsCountResponseOutputError>))]
        public global::Supabase.AnyOf<string, global::Supabase.V1GetUsageApiRequestsCountResponseOutputError>? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1GetUsageApiRequestsCountResponseOutput" /> class.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1GetUsageApiRequestsCountResponseOutput(
            global::System.Collections.Generic.IList<global::Supabase.V1GetUsageApiRequestsCountResponseOutputResultItem>? result,
            global::Supabase.AnyOf<string, global::Supabase.V1GetUsageApiRequestsCountResponseOutputError>? error)
        {
            this.Result = result;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1GetUsageApiRequestsCountResponseOutput" /> class.
        /// </summary>
        public V1GetUsageApiRequestsCountResponseOutput()
        {
        }

    }
}