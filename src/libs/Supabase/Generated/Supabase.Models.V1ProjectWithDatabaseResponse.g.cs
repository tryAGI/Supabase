
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1ProjectWithDatabaseResponse
    {
        /// <summary>
        /// Deprecated: Use `ref` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Project ref<br/>
        /// Example: abcdefghijklmnopqrst
        /// </summary>
        /// <example>abcdefghijklmnopqrst</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        /// Deprecated: Use `organization_slug` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// Organization slug<br/>
        /// Example: tsrqponmlkjihgfedcba
        /// </summary>
        /// <example>tsrqponmlkjihgfedcba</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationSlug { get; set; }

        /// <summary>
        /// Name of your project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Region of your project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// Creation timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.V1ProjectWithDatabaseResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.V1ProjectWithDatabaseResponseStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("database")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.V1ProjectWithDatabaseResponseDatabase Database { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ProjectWithDatabaseResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Deprecated: Use `ref` instead.
        /// </param>
        /// <param name="ref">
        /// Project ref<br/>
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="organizationId">
        /// Deprecated: Use `organization_slug` instead.
        /// </param>
        /// <param name="organizationSlug">
        /// Organization slug<br/>
        /// Example: tsrqponmlkjihgfedcba
        /// </param>
        /// <param name="name">
        /// Name of your project
        /// </param>
        /// <param name="region">
        /// Region of your project
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp
        /// </param>
        /// <param name="status"></param>
        /// <param name="database"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1ProjectWithDatabaseResponse(
            string id,
            string @ref,
            string organizationId,
            string organizationSlug,
            string name,
            string region,
            string createdAt,
            global::Supabase.V1ProjectWithDatabaseResponseStatus status,
            global::Supabase.V1ProjectWithDatabaseResponseDatabase database)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.OrganizationSlug = organizationSlug ?? throw new global::System.ArgumentNullException(nameof(organizationSlug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Status = status;
            this.Database = database ?? throw new global::System.ArgumentNullException(nameof(database));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ProjectWithDatabaseResponse" /> class.
        /// </summary>
        public V1ProjectWithDatabaseResponse()
        {
        }
    }
}