
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegionsInfoAll
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smartGroup")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.RegionsInfoAllSmartGroupItem> SmartGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("specific")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.RegionsInfoAllSpecificItem> Specific { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionsInfoAll" /> class.
        /// </summary>
        /// <param name="smartGroup"></param>
        /// <param name="specific"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegionsInfoAll(
            global::System.Collections.Generic.IList<global::Supabase.RegionsInfoAllSmartGroupItem> smartGroup,
            global::System.Collections.Generic.IList<global::Supabase.RegionsInfoAllSpecificItem> specific)
        {
            this.SmartGroup = smartGroup ?? throw new global::System.ArgumentNullException(nameof(smartGroup));
            this.Specific = specific ?? throw new global::System.ArgumentNullException(nameof(specific));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionsInfoAll" /> class.
        /// </summary>
        public RegionsInfoAll()
        {
        }
    }
}