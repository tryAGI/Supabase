
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegionsInfoRecommendationsSmartGroup
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.RegionsInfoRecommendationsSmartGroupCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.RegionsInfoRecommendationsSmartGroupCode Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.RegionsInfoRecommendationsSmartGroupTypeJsonConverter))]
        public global::Supabase.RegionsInfoRecommendationsSmartGroupType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionsInfoRecommendationsSmartGroup" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="code"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegionsInfoRecommendationsSmartGroup(
            string name,
            global::Supabase.RegionsInfoRecommendationsSmartGroupCode code,
            global::Supabase.RegionsInfoRecommendationsSmartGroupType type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Code = code;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionsInfoRecommendationsSmartGroup" /> class.
        /// </summary>
        public RegionsInfoRecommendationsSmartGroup()
        {
        }

    }
}