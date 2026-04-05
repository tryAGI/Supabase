
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DiskResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.OneOfJsonConverter<global::Supabase.DiskResponseAttributesVariant1, global::Supabase.DiskResponseAttributesVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.OneOf<global::Supabase.DiskResponseAttributesVariant1, global::Supabase.DiskResponseAttributesVariant2> Attributes { get; set; }

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
        /// Initializes a new instance of the <see cref="DiskResponse" /> class.
        /// </summary>
        /// <param name="attributes"></param>
        /// <param name="lastModifiedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiskResponse(
            global::Supabase.OneOf<global::Supabase.DiskResponseAttributesVariant1, global::Supabase.DiskResponseAttributesVariant2> attributes,
            string? lastModifiedAt)
        {
            this.Attributes = attributes;
            this.LastModifiedAt = lastModifiedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiskResponse" /> class.
        /// </summary>
        public DiskResponse()
        {
        }
    }
}