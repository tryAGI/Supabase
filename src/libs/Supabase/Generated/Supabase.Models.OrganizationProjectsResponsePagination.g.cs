
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationProjectsResponsePagination
    {
        /// <summary>
        /// Total number of projects. Use this to calculate the total number of pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// Maximum number of projects per page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Limit { get; set; }

        /// <summary>
        /// Number of projects skipped in this response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Offset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationProjectsResponsePagination" /> class.
        /// </summary>
        /// <param name="count">
        /// Total number of projects. Use this to calculate the total number of pages.
        /// </param>
        /// <param name="limit">
        /// Maximum number of projects per page
        /// </param>
        /// <param name="offset">
        /// Number of projects skipped in this response
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationProjectsResponsePagination(
            double count,
            double limit,
            double offset)
        {
            this.Count = count;
            this.Limit = limit;
            this.Offset = offset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationProjectsResponsePagination" /> class.
        /// </summary>
        public OrganizationProjectsResponsePagination()
        {
        }
    }
}