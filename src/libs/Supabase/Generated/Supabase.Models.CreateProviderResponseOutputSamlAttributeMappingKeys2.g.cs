
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateProviderResponseOutputSamlAttributeMappingKeys2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("names")]
        public global::System.Collections.Generic.IList<string>? Names { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("array")]
        public bool? Array { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.AnyOfJsonConverter<object, double?, string, bool?>))]
        public global::Supabase.AnyOf<object, double?, string, bool?>? Default { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProviderResponseOutputSamlAttributeMappingKeys2" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="names"></param>
        /// <param name="array"></param>
        /// <param name="default"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProviderResponseOutputSamlAttributeMappingKeys2(
            string? name,
            global::System.Collections.Generic.IList<string>? names,
            bool? array,
            global::Supabase.AnyOf<object, double?, string, bool?>? @default)
        {
            this.Name = name;
            this.Names = names;
            this.Array = array;
            this.Default = @default;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProviderResponseOutputSamlAttributeMappingKeys2" /> class.
        /// </summary>
        public CreateProviderResponseOutputSamlAttributeMappingKeys2()
        {
        }

    }
}