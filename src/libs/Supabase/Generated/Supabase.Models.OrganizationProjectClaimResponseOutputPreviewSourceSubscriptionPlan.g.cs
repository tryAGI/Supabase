
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum OrganizationProjectClaimResponseOutputPreviewSourceSubscriptionPlan
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
    public static class OrganizationProjectClaimResponseOutputPreviewSourceSubscriptionPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationProjectClaimResponseOutputPreviewSourceSubscriptionPlan value)
        {
            return value switch
            {
                OrganizationProjectClaimResponseOutputPreviewSourceSubscriptionPlan.Enterprise => "enterprise",
                OrganizationProjectClaimResponseOutputPreviewSourceSubscriptionPlan.Free => "free",
                OrganizationProjectClaimResponseOutputPreviewSourceSubscriptionPlan.Platform => "platform",
                OrganizationProjectClaimResponseOutputPreviewSourceSubscriptionPlan.Pro => "pro",
                OrganizationProjectClaimResponseOutputPreviewSourceSubscriptionPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationProjectClaimResponseOutputPreviewSourceSubscriptionPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => OrganizationProjectClaimResponseOutputPreviewSourceSubscriptionPlan.Enterprise,
                "free" => OrganizationProjectClaimResponseOutputPreviewSourceSubscriptionPlan.Free,
                "platform" => OrganizationProjectClaimResponseOutputPreviewSourceSubscriptionPlan.Platform,
                "pro" => OrganizationProjectClaimResponseOutputPreviewSourceSubscriptionPlan.Pro,
                "team" => OrganizationProjectClaimResponseOutputPreviewSourceSubscriptionPlan.Team,
                _ => null,
            };
        }
    }
}