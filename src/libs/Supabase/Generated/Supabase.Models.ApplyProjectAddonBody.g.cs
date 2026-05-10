
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"addon_variant":"pitr_7","addon_type":"pitr"}
    /// </summary>
    public sealed partial class ApplyProjectAddonBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addon_variant")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.OneOfJsonConverter<global::Supabase.ApplyProjectAddonBodyAddonVariantVariant1?, global::Supabase.ApplyProjectAddonBodyAddonVariantVariant2?, global::Supabase.ApplyProjectAddonBodyAddonVariantVariant3?, global::Supabase.ApplyProjectAddonBodyAddonVariantVariant4?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.OneOf<global::Supabase.ApplyProjectAddonBodyAddonVariantVariant1?, global::Supabase.ApplyProjectAddonBodyAddonVariantVariant2?, global::Supabase.ApplyProjectAddonBodyAddonVariantVariant3?, global::Supabase.ApplyProjectAddonBodyAddonVariantVariant4?> AddonVariant { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addon_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.ApplyProjectAddonBodyAddonTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.ApplyProjectAddonBodyAddonType AddonType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyProjectAddonBody" /> class.
        /// </summary>
        /// <param name="addonVariant"></param>
        /// <param name="addonType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApplyProjectAddonBody(
            global::Supabase.OneOf<global::Supabase.ApplyProjectAddonBodyAddonVariantVariant1?, global::Supabase.ApplyProjectAddonBodyAddonVariantVariant2?, global::Supabase.ApplyProjectAddonBodyAddonVariantVariant3?, global::Supabase.ApplyProjectAddonBodyAddonVariantVariant4?> addonVariant,
            global::Supabase.ApplyProjectAddonBodyAddonType addonType)
        {
            this.AddonVariant = addonVariant;
            this.AddonType = addonType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyProjectAddonBody" /> class.
        /// </summary>
        public ApplyProjectAddonBody()
        {
        }

    }
}