
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1ListMigrationsResponseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ListMigrationsResponseItem" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1ListMigrationsResponseItem(
            string version,
            string? name)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ListMigrationsResponseItem" /> class.
        /// </summary>
        public V1ListMigrationsResponseItem()
        {
        }

    }
}