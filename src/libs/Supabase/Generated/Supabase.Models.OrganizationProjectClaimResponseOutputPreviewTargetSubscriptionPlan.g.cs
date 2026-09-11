
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum OrganizationProjectClaimResponseOutputPreviewTargetSubscriptionPlan
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
    public static class OrganizationProjectClaimResponseOutputPreviewTargetSubscriptionPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationProjectClaimResponseOutputPreviewTargetSubscriptionPlan value)
        {
            return value switch
            {
                OrganizationProjectClaimResponseOutputPreviewTargetSubscriptionPlan.Enterprise => "enterprise",
                OrganizationProjectClaimResponseOutputPreviewTargetSubscriptionPlan.Free => "free",
                OrganizationProjectClaimResponseOutputPreviewTargetSubscriptionPlan.Platform => "platform",
                OrganizationProjectClaimResponseOutputPreviewTargetSubscriptionPlan.Pro => "pro",
                OrganizationProjectClaimResponseOutputPreviewTargetSubscriptionPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationProjectClaimResponseOutputPreviewTargetSubscriptionPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => OrganizationProjectClaimResponseOutputPreviewTargetSubscriptionPlan.Enterprise,
                "free" => OrganizationProjectClaimResponseOutputPreviewTargetSubscriptionPlan.Free,
                "platform" => OrganizationProjectClaimResponseOutputPreviewTargetSubscriptionPlan.Platform,
                "pro" => OrganizationProjectClaimResponseOutputPreviewTargetSubscriptionPlan.Pro,
                "team" => OrganizationProjectClaimResponseOutputPreviewTargetSubscriptionPlan.Team,
                _ => null,
            };
        }
    }
}