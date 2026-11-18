
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseOutputValidationErrorVariant11Type
    {
        /// <summary>
        ///
        /// </summary>
        ProjectHibernating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseOutputValidationErrorVariant11TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseOutputValidationErrorVariant11Type value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseOutputValidationErrorVariant11Type.ProjectHibernating => "project_hibernating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseOutputValidationErrorVariant11Type? ToEnum(string value)
        {
            return value switch
            {
                "project_hibernating" => ProjectUpgradeEligibilityResponseOutputValidationErrorVariant11Type.ProjectHibernating,
                _ => null,
            };
        }
    }
}