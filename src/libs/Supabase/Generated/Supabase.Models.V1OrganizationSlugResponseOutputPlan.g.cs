
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum V1OrganizationSlugResponseOutputPlan
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
    public static class V1OrganizationSlugResponseOutputPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1OrganizationSlugResponseOutputPlan value)
        {
            return value switch
            {
                V1OrganizationSlugResponseOutputPlan.Enterprise => "enterprise",
                V1OrganizationSlugResponseOutputPlan.Free => "free",
                V1OrganizationSlugResponseOutputPlan.Platform => "platform",
                V1OrganizationSlugResponseOutputPlan.Pro => "pro",
                V1OrganizationSlugResponseOutputPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1OrganizationSlugResponseOutputPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => V1OrganizationSlugResponseOutputPlan.Enterprise,
                "free" => V1OrganizationSlugResponseOutputPlan.Free,
                "platform" => V1OrganizationSlugResponseOutputPlan.Platform,
                "pro" => V1OrganizationSlugResponseOutputPlan.Pro,
                "team" => V1OrganizationSlugResponseOutputPlan.Team,
                _ => null,
            };
        }
    }
}