
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SnippetListOutputDataItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inserted_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InsertedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.SnippetListOutputDataItemTypeJsonConverter))]
        public global::Supabase.SnippetListOutputDataItemType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.SnippetListOutputDataItemVisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.SnippetListOutputDataItemVisibility Visibility { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.SnippetListOutputDataItemProject Project { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.SnippetListOutputDataItemOwner Owner { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.SnippetListOutputDataItemUpdatedBy UpdatedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("favorite")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Favorite { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SnippetListOutputDataItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="insertedAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="visibility"></param>
        /// <param name="name"></param>
        /// <param name="project"></param>
        /// <param name="owner"></param>
        /// <param name="updatedBy"></param>
        /// <param name="favorite"></param>
        /// <param name="type"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SnippetListOutputDataItem(
            string id,
            string insertedAt,
            string updatedAt,
            global::Supabase.SnippetListOutputDataItemVisibility visibility,
            string name,
            global::Supabase.SnippetListOutputDataItemProject project,
            global::Supabase.SnippetListOutputDataItemOwner owner,
            global::Supabase.SnippetListOutputDataItemUpdatedBy updatedBy,
            bool favorite,
            global::Supabase.SnippetListOutputDataItemType type,
            string? description)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.InsertedAt = insertedAt ?? throw new global::System.ArgumentNullException(nameof(insertedAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Type = type;
            this.Visibility = visibility;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.UpdatedBy = updatedBy ?? throw new global::System.ArgumentNullException(nameof(updatedBy));
            this.Favorite = favorite;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SnippetListOutputDataItem" /> class.
        /// </summary>
        public SnippetListOutputDataItem()
        {
        }

    }
}