
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkUpdateFunctionBodyItem
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
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.BulkUpdateFunctionBodyItemStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.BulkUpdateFunctionBodyItemStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verify_jwt")]
        public bool? VerifyJwt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("import_map")]
        public bool? ImportMap { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entrypoint_path")]
        public string? EntrypointPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("import_map_path")]
        public string? ImportMapPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ezbr_sha256")]
        public string? EzbrSha256 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateFunctionBodyItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="slug"></param>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <param name="version"></param>
        /// <param name="createdAt"></param>
        /// <param name="verifyJwt"></param>
        /// <param name="importMap"></param>
        /// <param name="entrypointPath"></param>
        /// <param name="importMapPath"></param>
        /// <param name="ezbrSha256"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkUpdateFunctionBodyItem(
            string id,
            string slug,
            string name,
            global::Supabase.BulkUpdateFunctionBodyItemStatus status,
            int version,
            long? createdAt,
            bool? verifyJwt,
            bool? importMap,
            string? entrypointPath,
            string? importMapPath,
            string? ezbrSha256)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status;
            this.Version = version;
            this.CreatedAt = createdAt;
            this.VerifyJwt = verifyJwt;
            this.ImportMap = importMap;
            this.EntrypointPath = entrypointPath;
            this.ImportMapPath = importMapPath;
            this.EzbrSha256 = ezbrSha256;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateFunctionBodyItem" /> class.
        /// </summary>
        public BulkUpdateFunctionBodyItem()
        {
        }

    }
}