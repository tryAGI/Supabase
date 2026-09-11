
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RegionsInfoOutputRecommendationsSpecificItem
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.RegionsInfoOutputRecommendationsSpecificItemCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.RegionsInfoOutputRecommendationsSpecificItemCode Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.RegionsInfoOutputRecommendationsSpecificItemTypeJsonConverter))]
        public global::Supabase.RegionsInfoOutputRecommendationsSpecificItemType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.RegionsInfoOutputRecommendationsSpecificItemProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.RegionsInfoOutputRecommendationsSpecificItemProvider Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.RegionsInfoOutputRecommendationsSpecificItemStatusJsonConverter))]
        public global::Supabase.RegionsInfoOutputRecommendationsSpecificItemStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionsInfoOutputRecommendationsSpecificItem" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="code"></param>
        /// <param name="provider"></param>
        /// <param name="type"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegionsInfoOutputRecommendationsSpecificItem(
            string name,
            global::Supabase.RegionsInfoOutputRecommendationsSpecificItemCode code,
            global::Supabase.RegionsInfoOutputRecommendationsSpecificItemProvider provider,
            global::Supabase.RegionsInfoOutputRecommendationsSpecificItemType type,
            global::Supabase.RegionsInfoOutputRecommendationsSpecificItemStatus? status)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Code = code;
            this.Type = type;
            this.Provider = provider;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionsInfoOutputRecommendationsSpecificItem" /> class.
        /// </summary>
        public RegionsInfoOutputRecommendationsSpecificItem()
        {
        }

    }
}