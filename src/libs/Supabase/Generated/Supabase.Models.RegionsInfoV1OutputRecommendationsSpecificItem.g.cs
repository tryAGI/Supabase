
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RegionsInfoV1OutputRecommendationsSpecificItem
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.RegionsInfoV1OutputRecommendationsSpecificItemCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.RegionsInfoV1OutputRecommendationsSpecificItemCode Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.RegionsInfoV1OutputRecommendationsSpecificItemTypeJsonConverter))]
        public global::Supabase.RegionsInfoV1OutputRecommendationsSpecificItemType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.RegionsInfoV1OutputRecommendationsSpecificItemProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.RegionsInfoV1OutputRecommendationsSpecificItemProvider Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.RegionsInfoV1OutputRecommendationsSpecificItemStatusJsonConverter))]
        public global::Supabase.RegionsInfoV1OutputRecommendationsSpecificItemStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionsInfoV1OutputRecommendationsSpecificItem" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="code"></param>
        /// <param name="provider"></param>
        /// <param name="type"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegionsInfoV1OutputRecommendationsSpecificItem(
            string name,
            global::Supabase.RegionsInfoV1OutputRecommendationsSpecificItemCode code,
            global::Supabase.RegionsInfoV1OutputRecommendationsSpecificItemProvider provider,
            global::Supabase.RegionsInfoV1OutputRecommendationsSpecificItemType type,
            global::Supabase.RegionsInfoV1OutputRecommendationsSpecificItemStatus? status)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Code = code;
            this.Type = type;
            this.Provider = provider;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionsInfoV1OutputRecommendationsSpecificItem" /> class.
        /// </summary>
        public RegionsInfoV1OutputRecommendationsSpecificItem()
        {
        }

    }
}