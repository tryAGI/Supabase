
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseValidationErrorVariant10Type
    {
        /// <summary>
        /// 
        /// </summary>
        ProjectHibernating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseValidationErrorVariant10TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseValidationErrorVariant10Type value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseValidationErrorVariant10Type.ProjectHibernating => "project_hibernating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseValidationErrorVariant10Type? ToEnum(string value)
        {
            return value switch
            {
                "project_hibernating" => ProjectUpgradeEligibilityResponseValidationErrorVariant10Type.ProjectHibernating,
                _ => null,
            };
        }
    }
}