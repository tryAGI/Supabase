
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1CreateProjectBodyRegionSelectionVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.V1CreateProjectBodyRegionSelectionVariant1TypeJsonConverter))]
        public global::Supabase.V1CreateProjectBodyRegionSelectionVariant1Type Type { get; set; }

        /// <summary>
        /// Specific region code. The codes supported are not a stable API, and should be retrieved from the /available-regions endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.V1CreateProjectBodyRegionSelectionVariant1CodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.V1CreateProjectBodyRegionSelectionVariant1Code Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1CreateProjectBodyRegionSelectionVariant1" /> class.
        /// </summary>
        /// <param name="code">
        /// Specific region code. The codes supported are not a stable API, and should be retrieved from the /available-regions endpoint.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1CreateProjectBodyRegionSelectionVariant1(
            global::Supabase.V1CreateProjectBodyRegionSelectionVariant1Code code,
            global::Supabase.V1CreateProjectBodyRegionSelectionVariant1Type type)
        {
            this.Type = type;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1CreateProjectBodyRegionSelectionVariant1" /> class.
        /// </summary>
        public V1CreateProjectBodyRegionSelectionVariant1()
        {
        }
    }
}