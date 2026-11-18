
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseOutputValidationErrorVariant9Type
    {
        /// <summary>
        ///
        /// </summary>
        TableUsingRegType,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseOutputValidationErrorVariant9TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseOutputValidationErrorVariant9Type value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseOutputValidationErrorVariant9Type.TableUsingRegType => "table_using_reg_type",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseOutputValidationErrorVariant9Type? ToEnum(string value)
        {
            return value switch
            {
                "table_using_reg_type" => ProjectUpgradeEligibilityResponseOutputValidationErrorVariant9Type.TableUsingRegType,
                _ => null,
            };
        }
    }
}