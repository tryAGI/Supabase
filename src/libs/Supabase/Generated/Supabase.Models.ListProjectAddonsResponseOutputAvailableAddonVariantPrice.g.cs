
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListProjectAddonsResponseOutputAvailableAddonVariantPrice
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseOutputAvailableAddonVariantPriceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantPriceType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseOutputAvailableAddonVariantPriceIntervalJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantPriceInterval Interval { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Amount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectAddonsResponseOutputAvailableAddonVariantPrice" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="type"></param>
        /// <param name="interval"></param>
        /// <param name="amount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectAddonsResponseOutputAvailableAddonVariantPrice(
            string description,
            global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantPriceType type,
            global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantPriceInterval interval,
            double amount)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Type = type;
            this.Interval = interval;
            this.Amount = amount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectAddonsResponseOutputAvailableAddonVariantPrice" /> class.
        /// </summary>
        public ListProjectAddonsResponseOutputAvailableAddonVariantPrice()
        {
        }

    }
}