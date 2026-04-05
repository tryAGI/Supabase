
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrganizationProjectClaimResponsePreviewTargetSubscriptionPlan
    {
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        Free,
        /// <summary>
        /// 
        /// </summary>
        Platform,
        /// <summary>
        /// 
        /// </summary>
        Pro,
        /// <summary>
        /// 
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationProjectClaimResponsePreviewTargetSubscriptionPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationProjectClaimResponsePreviewTargetSubscriptionPlan value)
        {
            return value switch
            {
                OrganizationProjectClaimResponsePreviewTargetSubscriptionPlan.Enterprise => "enterprise",
                OrganizationProjectClaimResponsePreviewTargetSubscriptionPlan.Free => "free",
                OrganizationProjectClaimResponsePreviewTargetSubscriptionPlan.Platform => "platform",
                OrganizationProjectClaimResponsePreviewTargetSubscriptionPlan.Pro => "pro",
                OrganizationProjectClaimResponsePreviewTargetSubscriptionPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationProjectClaimResponsePreviewTargetSubscriptionPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => OrganizationProjectClaimResponsePreviewTargetSubscriptionPlan.Enterprise,
                "free" => OrganizationProjectClaimResponsePreviewTargetSubscriptionPlan.Free,
                "platform" => OrganizationProjectClaimResponsePreviewTargetSubscriptionPlan.Platform,
                "pro" => OrganizationProjectClaimResponsePreviewTargetSubscriptionPlan.Pro,
                "team" => OrganizationProjectClaimResponsePreviewTargetSubscriptionPlan.Team,
                _ => null,
            };
        }
    }
}