
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RegionsInfoV1OutputRecommendationsSmartGroup
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.RegionsInfoV1OutputRecommendationsSmartGroupCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.RegionsInfoV1OutputRecommendationsSmartGroupCode Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.RegionsInfoV1OutputRecommendationsSmartGroupTypeJsonConverter))]
        public global::Supabase.RegionsInfoV1OutputRecommendationsSmartGroupType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionsInfoV1OutputRecommendationsSmartGroup" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="code"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegionsInfoV1OutputRecommendationsSmartGroup(
            string name,
            global::Supabase.RegionsInfoV1OutputRecommendationsSmartGroupCode code,
            global::Supabase.RegionsInfoV1OutputRecommendationsSmartGroupType type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Code = code;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionsInfoV1OutputRecommendationsSmartGroup" /> class.
        /// </summary>
        public RegionsInfoV1OutputRecommendationsSmartGroup()
        {
        }

    }
}