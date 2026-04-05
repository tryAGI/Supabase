
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseValidationErrorVariant5Type
    {
        /// <summary>
        /// 
        /// </summary>
        UnsupportedFdwHandler,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseValidationErrorVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseValidationErrorVariant5Type value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseValidationErrorVariant5Type.UnsupportedFdwHandler => "unsupported_fdw_handler",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseValidationErrorVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "unsupported_fdw_handler" => ProjectUpgradeEligibilityResponseValidationErrorVariant5Type.UnsupportedFdwHandler,
                _ => null,
            };
        }
    }
}