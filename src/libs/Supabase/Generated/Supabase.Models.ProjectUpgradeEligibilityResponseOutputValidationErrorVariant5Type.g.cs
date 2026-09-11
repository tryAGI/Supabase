
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseOutputValidationErrorVariant5Type
    {
        /// <summary>
        ///
        /// </summary>
        UnsupportedFdwHandler,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseOutputValidationErrorVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseOutputValidationErrorVariant5Type value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseOutputValidationErrorVariant5Type.UnsupportedFdwHandler => "unsupported_fdw_handler",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseOutputValidationErrorVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "unsupported_fdw_handler" => ProjectUpgradeEligibilityResponseOutputValidationErrorVariant5Type.UnsupportedFdwHandler,
                _ => null,
            };
        }
    }
}