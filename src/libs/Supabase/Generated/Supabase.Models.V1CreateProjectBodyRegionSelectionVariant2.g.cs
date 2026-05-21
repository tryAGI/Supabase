
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1CreateProjectBodyRegionSelectionVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.V1CreateProjectBodyRegionSelectionVariant2TypeJsonConverter))]
        public global::Supabase.V1CreateProjectBodyRegionSelectionVariant2Type Type { get; set; }

        /// <summary>
        /// The Smart Region Group's code. The codes supported are not a stable API, and should be retrieved from the /available-regions endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.V1CreateProjectBodyRegionSelectionVariant2CodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.V1CreateProjectBodyRegionSelectionVariant2Code Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1CreateProjectBodyRegionSelectionVariant2" /> class.
        /// </summary>
        /// <param name="code">
        /// The Smart Region Group's code. The codes supported are not a stable API, and should be retrieved from the /available-regions endpoint.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1CreateProjectBodyRegionSelectionVariant2(
            global::Supabase.V1CreateProjectBodyRegionSelectionVariant2Code code,
            global::Supabase.V1CreateProjectBodyRegionSelectionVariant2Type type)
        {
            this.Type = type;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1CreateProjectBodyRegionSelectionVariant2" /> class.
        /// </summary>
        public V1CreateProjectBodyRegionSelectionVariant2()
        {
        }

    }
}