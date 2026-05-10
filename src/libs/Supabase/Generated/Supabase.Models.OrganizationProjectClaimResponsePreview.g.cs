
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationProjectClaimResponsePreview
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Valid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.OrganizationProjectClaimResponsePreviewWarning> Warnings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.OrganizationProjectClaimResponsePreviewError> Errors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.OrganizationProjectClaimResponsePreviewInfoItem> Info { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_exceeding_free_project_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.OrganizationProjectClaimResponsePreviewMembersExceedingFreeProjectLimitItem> MembersExceedingFreeProjectLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_subscription_plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.OrganizationProjectClaimResponsePreviewSourceSubscriptionPlanJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.OrganizationProjectClaimResponsePreviewSourceSubscriptionPlan SourceSubscriptionPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_subscription_plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.OrganizationProjectClaimResponsePreviewTargetSubscriptionPlanJsonConverter))]
        public global::Supabase.OrganizationProjectClaimResponsePreviewTargetSubscriptionPlan? TargetSubscriptionPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationProjectClaimResponsePreview" /> class.
        /// </summary>
        /// <param name="valid"></param>
        /// <param name="warnings"></param>
        /// <param name="errors"></param>
        /// <param name="info"></param>
        /// <param name="membersExceedingFreeProjectLimit"></param>
        /// <param name="sourceSubscriptionPlan"></param>
        /// <param name="targetSubscriptionPlan"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationProjectClaimResponsePreview(
            bool valid,
            global::System.Collections.Generic.IList<global::Supabase.OrganizationProjectClaimResponsePreviewWarning> warnings,
            global::System.Collections.Generic.IList<global::Supabase.OrganizationProjectClaimResponsePreviewError> errors,
            global::System.Collections.Generic.IList<global::Supabase.OrganizationProjectClaimResponsePreviewInfoItem> info,
            global::System.Collections.Generic.IList<global::Supabase.OrganizationProjectClaimResponsePreviewMembersExceedingFreeProjectLimitItem> membersExceedingFreeProjectLimit,
            global::Supabase.OrganizationProjectClaimResponsePreviewSourceSubscriptionPlan sourceSubscriptionPlan,
            global::Supabase.OrganizationProjectClaimResponsePreviewTargetSubscriptionPlan? targetSubscriptionPlan)
        {
            this.Valid = valid;
            this.Warnings = warnings ?? throw new global::System.ArgumentNullException(nameof(warnings));
            this.Errors = errors ?? throw new global::System.ArgumentNullException(nameof(errors));
            this.Info = info ?? throw new global::System.ArgumentNullException(nameof(info));
            this.MembersExceedingFreeProjectLimit = membersExceedingFreeProjectLimit ?? throw new global::System.ArgumentNullException(nameof(membersExceedingFreeProjectLimit));
            this.SourceSubscriptionPlan = sourceSubscriptionPlan;
            this.TargetSubscriptionPlan = targetSubscriptionPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationProjectClaimResponsePreview" /> class.
        /// </summary>
        public OrganizationProjectClaimResponsePreview()
        {
        }

    }
}