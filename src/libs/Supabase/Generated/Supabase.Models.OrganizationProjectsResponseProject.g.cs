
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationProjectsResponseProject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloud_provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CloudProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_branch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.OrganizationProjectsResponseProjectStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.OrganizationProjectsResponseProjectStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inserted_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InsertedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("databases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.OrganizationProjectsResponseProjectDatabase> Databases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationProjectsResponseProject" /> class.
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="name"></param>
        /// <param name="cloudProvider"></param>
        /// <param name="region"></param>
        /// <param name="isBranch"></param>
        /// <param name="status"></param>
        /// <param name="insertedAt"></param>
        /// <param name="databases"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationProjectsResponseProject(
            string @ref,
            string name,
            string cloudProvider,
            string region,
            bool isBranch,
            global::Supabase.OrganizationProjectsResponseProjectStatus status,
            string insertedAt,
            global::System.Collections.Generic.IList<global::Supabase.OrganizationProjectsResponseProjectDatabase> databases)
        {
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CloudProvider = cloudProvider ?? throw new global::System.ArgumentNullException(nameof(cloudProvider));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.IsBranch = isBranch;
            this.Status = status;
            this.InsertedAt = insertedAt ?? throw new global::System.ArgumentNullException(nameof(insertedAt));
            this.Databases = databases ?? throw new global::System.ArgumentNullException(nameof(databases));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationProjectsResponseProject" /> class.
        /// </summary>
        public OrganizationProjectsResponseProject()
        {
        }
    }
}