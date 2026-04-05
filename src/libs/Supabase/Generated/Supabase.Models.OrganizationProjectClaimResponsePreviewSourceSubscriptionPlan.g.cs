
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrganizationProjectClaimResponsePreviewSourceSubscriptionPlan
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
    public static class OrganizationProjectClaimResponsePreviewSourceSubscriptionPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationProjectClaimResponsePreviewSourceSubscriptionPlan value)
        {
            return value switch
            {
                OrganizationProjectClaimResponsePreviewSourceSubscriptionPlan.Enterprise => "enterprise",
                OrganizationProjectClaimResponsePreviewSourceSubscriptionPlan.Free => "free",
                OrganizationProjectClaimResponsePreviewSourceSubscriptionPlan.Platform => "platform",
                OrganizationProjectClaimResponsePreviewSourceSubscriptionPlan.Pro => "pro",
                OrganizationProjectClaimResponsePreviewSourceSubscriptionPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationProjectClaimResponsePreviewSourceSubscriptionPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => OrganizationProjectClaimResponsePreviewSourceSubscriptionPlan.Enterprise,
                "free" => OrganizationProjectClaimResponsePreviewSourceSubscriptionPlan.Free,
                "platform" => OrganizationProjectClaimResponsePreviewSourceSubscriptionPlan.Platform,
                "pro" => OrganizationProjectClaimResponsePreviewSourceSubscriptionPlan.Pro,
                "team" => OrganizationProjectClaimResponsePreviewSourceSubscriptionPlan.Team,
                _ => null,
            };
        }
    }
}