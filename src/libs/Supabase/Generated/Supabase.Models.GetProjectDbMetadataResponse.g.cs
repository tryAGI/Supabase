
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectDbMetadataResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("databases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.GetProjectDbMetadataResponseDatabase> Databases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectDbMetadataResponse" /> class.
        /// </summary>
        /// <param name="databases"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectDbMetadataResponse(
            global::System.Collections.Generic.IList<global::Supabase.GetProjectDbMetadataResponseDatabase> databases)
        {
            this.Databases = databases ?? throw new global::System.ArgumentNullException(nameof(databases));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectDbMetadataResponse" /> class.
        /// </summary>
        public GetProjectDbMetadataResponse()
        {
        }

    }
}