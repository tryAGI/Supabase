
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RegionsInfoV1OutputAllSpecificItem
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.RegionsInfoV1OutputAllSpecificItemCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.RegionsInfoV1OutputAllSpecificItemCode Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.RegionsInfoV1OutputAllSpecificItemTypeJsonConverter))]
        public global::Supabase.RegionsInfoV1OutputAllSpecificItemType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.RegionsInfoV1OutputAllSpecificItemProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.RegionsInfoV1OutputAllSpecificItemProvider Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.RegionsInfoV1OutputAllSpecificItemStatusJsonConverter))]
        public global::Supabase.RegionsInfoV1OutputAllSpecificItemStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionsInfoV1OutputAllSpecificItem" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="code"></param>
        /// <param name="provider"></param>
        /// <param name="type"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegionsInfoV1OutputAllSpecificItem(
            string name,
            global::Supabase.RegionsInfoV1OutputAllSpecificItemCode code,
            global::Supabase.RegionsInfoV1OutputAllSpecificItemProvider provider,
            global::Supabase.RegionsInfoV1OutputAllSpecificItemType type,
            global::Supabase.RegionsInfoV1OutputAllSpecificItemStatus? status)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Code = code;
            this.Type = type;
            this.Provider = provider;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionsInfoV1OutputAllSpecificItem" /> class.
        /// </summary>
        public RegionsInfoV1OutputAllSpecificItem()
        {
        }

    }
}