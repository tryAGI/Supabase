
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationProjectClaimResponsePreviewMembersExceedingFreeProjectLimitItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationProjectClaimResponsePreviewMembersExceedingFreeProjectLimitItem" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="limit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationProjectClaimResponsePreviewMembersExceedingFreeProjectLimitItem(
            string name,
            double limit)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationProjectClaimResponsePreviewMembersExceedingFreeProjectLimitItem" /> class.
        /// </summary>
        public OrganizationProjectClaimResponsePreviewMembersExceedingFreeProjectLimitItem()
        {
        }

    }
}