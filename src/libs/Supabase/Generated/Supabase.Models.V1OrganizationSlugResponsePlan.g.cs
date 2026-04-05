
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1OrganizationSlugResponsePlan
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
    public static class V1OrganizationSlugResponsePlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1OrganizationSlugResponsePlan value)
        {
            return value switch
            {
                V1OrganizationSlugResponsePlan.Enterprise => "enterprise",
                V1OrganizationSlugResponsePlan.Free => "free",
                V1OrganizationSlugResponsePlan.Platform => "platform",
                V1OrganizationSlugResponsePlan.Pro => "pro",
                V1OrganizationSlugResponsePlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1OrganizationSlugResponsePlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => V1OrganizationSlugResponsePlan.Enterprise,
                "free" => V1OrganizationSlugResponsePlan.Free,
                "platform" => V1OrganizationSlugResponsePlan.Platform,
                "pro" => V1OrganizationSlugResponsePlan.Pro,
                "team" => V1OrganizationSlugResponsePlan.Team,
                _ => null,
            };
        }
    }
}