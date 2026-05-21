
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteProviderResponseSamlAttributeMappingKeys2
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
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.OneOfJsonConverter<object, double?, string, bool?>))]
        public global::Supabase.OneOf<object, double?, string, bool?>? Default { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("array")]
        public bool? Array { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteProviderResponseSamlAttributeMappingKeys2" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="names"></param>
        /// <param name="default"></param>
        /// <param name="array"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteProviderResponseSamlAttributeMappingKeys2(
            string? name,
            global::System.Collections.Generic.IList<string>? names,
            global::Supabase.OneOf<object, double?, string, bool?>? @default,
            bool? array)
        {
            this.Name = name;
            this.Names = names;
            this.Default = @default;
            this.Array = array;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteProviderResponseSamlAttributeMappingKeys2" /> class.
        /// </summary>
        public DeleteProviderResponseSamlAttributeMappingKeys2()
        {
        }

    }
}