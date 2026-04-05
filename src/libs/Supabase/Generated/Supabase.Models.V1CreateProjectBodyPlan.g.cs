
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Subscription Plan is now set on organization level and is ignored in this request
    /// </summary>
    public enum V1CreateProjectBodyPlan
    {
        /// <summary>
        /// 
        /// </summary>
        Free,
        /// <summary>
        /// 
        /// </summary>
        Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1CreateProjectBodyPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1CreateProjectBodyPlan value)
        {
            return value switch
            {
                V1CreateProjectBodyPlan.Free => "free",
                V1CreateProjectBodyPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1CreateProjectBodyPlan? ToEnum(string value)
        {
            return value switch
            {
                "free" => V1CreateProjectBodyPlan.Free,
                "pro" => V1CreateProjectBodyPlan.Pro,
                _ => null,
            };
        }
    }
}