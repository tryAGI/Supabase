
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegionsInfoAllSmartGroupItem
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.RegionsInfoAllSmartGroupItemCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.RegionsInfoAllSmartGroupItemCode Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.RegionsInfoAllSmartGroupItemTypeJsonConverter))]
        public global::Supabase.RegionsInfoAllSmartGroupItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionsInfoAllSmartGroupItem" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="code"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegionsInfoAllSmartGroupItem(
            string name,
            global::Supabase.RegionsInfoAllSmartGroupItemCode code,
            global::Supabase.RegionsInfoAllSmartGroupItemType type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Code = code;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionsInfoAllSmartGroupItem" /> class.
        /// </summary>
        public RegionsInfoAllSmartGroupItem()
        {
        }

    }
}