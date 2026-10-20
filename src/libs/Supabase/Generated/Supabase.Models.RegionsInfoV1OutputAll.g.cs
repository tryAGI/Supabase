
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RegionsInfoV1OutputAll
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smartGroup")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.RegionsInfoV1OutputAllSmartGroupItem> SmartGroup { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("specific")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.RegionsInfoV1OutputAllSpecificItem> Specific { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionsInfoV1OutputAll" /> class.
        /// </summary>
        /// <param name="smartGroup"></param>
        /// <param name="specific"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegionsInfoV1OutputAll(
            global::System.Collections.Generic.IList<global::Supabase.RegionsInfoV1OutputAllSmartGroupItem> smartGroup,
            global::System.Collections.Generic.IList<global::Supabase.RegionsInfoV1OutputAllSpecificItem> specific)
        {
            this.SmartGroup = smartGroup ?? throw new global::System.ArgumentNullException(nameof(smartGroup));
            this.Specific = specific ?? throw new global::System.ArgumentNullException(nameof(specific));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionsInfoV1OutputAll" /> class.
        /// </summary>
        public RegionsInfoV1OutputAll()
        {
        }

    }
}