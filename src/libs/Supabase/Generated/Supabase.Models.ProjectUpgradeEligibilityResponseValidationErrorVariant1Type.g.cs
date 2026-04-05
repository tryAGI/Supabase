
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseValidationErrorVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        ObjectsDependingOnPgCron,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseValidationErrorVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseValidationErrorVariant1Type value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseValidationErrorVariant1Type.ObjectsDependingOnPgCron => "objects_depending_on_pg_cron",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseValidationErrorVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "objects_depending_on_pg_cron" => ProjectUpgradeEligibilityResponseValidationErrorVariant1Type.ObjectsDependingOnPgCron,
                _ => null,
            };
        }
    }
}