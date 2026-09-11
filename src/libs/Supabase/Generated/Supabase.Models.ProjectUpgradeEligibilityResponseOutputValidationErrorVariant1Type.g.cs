
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseOutputValidationErrorVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        ObjectsDependingOnPgCron,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseOutputValidationErrorVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseOutputValidationErrorVariant1Type value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseOutputValidationErrorVariant1Type.ObjectsDependingOnPgCron => "objects_depending_on_pg_cron",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseOutputValidationErrorVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "objects_depending_on_pg_cron" => ProjectUpgradeEligibilityResponseOutputValidationErrorVariant1Type.ObjectsDependingOnPgCron,
                _ => null,
            };
        }
    }
}