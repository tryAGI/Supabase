
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1CreateProjectBodyRegionSelectionDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.V1CreateProjectBodyRegionSelectionDiscriminatorTypeJsonConverter))]
        public global::Supabase.V1CreateProjectBodyRegionSelectionDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1CreateProjectBodyRegionSelectionDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1CreateProjectBodyRegionSelectionDiscriminator(
            global::Supabase.V1CreateProjectBodyRegionSelectionDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1CreateProjectBodyRegionSelectionDiscriminator" /> class.
        /// </summary>
        public V1CreateProjectBodyRegionSelectionDiscriminator()
        {
        }
    }
}