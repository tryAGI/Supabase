
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RegionsInfoV1OutputAllSmartGroupItem
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.RegionsInfoV1OutputAllSmartGroupItemCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.RegionsInfoV1OutputAllSmartGroupItemCode Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.RegionsInfoV1OutputAllSmartGroupItemTypeJsonConverter))]
        public global::Supabase.RegionsInfoV1OutputAllSmartGroupItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionsInfoV1OutputAllSmartGroupItem" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="code"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegionsInfoV1OutputAllSmartGroupItem(
            string name,
            global::Supabase.RegionsInfoV1OutputAllSmartGroupItemCode code,
            global::Supabase.RegionsInfoV1OutputAllSmartGroupItemType type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Code = code;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionsInfoV1OutputAllSmartGroupItem" /> class.
        /// </summary>
        public RegionsInfoV1OutputAllSmartGroupItem()
        {
        }

    }
}