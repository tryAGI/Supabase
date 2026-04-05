
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionDeployBodyMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entrypoint_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntrypointPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("import_map_path")]
        public string? ImportMapPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("static_patterns")]
        public global::System.Collections.Generic.IList<string>? StaticPatterns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verify_jwt")]
        public bool? VerifyJwt { get; set; }

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
        /// Initializes a new instance of the <see cref="FunctionDeployBodyMetadata" /> class.
        /// </summary>
        /// <param name="entrypointPath"></param>
        /// <param name="importMapPath"></param>
        /// <param name="staticPatterns"></param>
        /// <param name="verifyJwt"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionDeployBodyMetadata(
            string entrypointPath,
            string? importMapPath,
            global::System.Collections.Generic.IList<string>? staticPatterns,
            bool? verifyJwt,
            string? name)
        {
            this.EntrypointPath = entrypointPath ?? throw new global::System.ArgumentNullException(nameof(entrypointPath));
            this.ImportMapPath = importMapPath;
            this.StaticPatterns = staticPatterns;
            this.VerifyJwt = verifyJwt;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDeployBodyMetadata" /> class.
        /// </summary>
        public FunctionDeployBodyMetadata()
        {
        }
    }
}