
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DiskResponseOutput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.AnyOfJsonConverter<global::Supabase.DiskResponseOutputAttributesVariant1, global::Supabase.DiskResponseOutputAttributesVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.AnyOf<global::Supabase.DiskResponseOutputAttributesVariant1, global::Supabase.DiskResponseOutputAttributesVariant2> Attributes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_modified_at")]
        public string? LastModifiedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiskResponseOutput" /> class.
        /// </summary>
        /// <param name="attributes"></param>
        /// <param name="lastModifiedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiskResponseOutput(
            global::Supabase.AnyOf<global::Supabase.DiskResponseOutputAttributesVariant1, global::Supabase.DiskResponseOutputAttributesVariant2> attributes,
            string? lastModifiedAt)
        {
            this.Attributes = attributes;
            this.LastModifiedAt = lastModifiedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiskResponseOutput" /> class.
        /// </summary>
        public DiskResponseOutput()
        {
        }

    }
}