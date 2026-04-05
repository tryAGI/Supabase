
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseValidationErrorVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        FunctionUsingObsoleteLang,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseValidationErrorVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseValidationErrorVariant3Type value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseValidationErrorVariant3Type.FunctionUsingObsoleteLang => "function_using_obsolete_lang",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseValidationErrorVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "function_using_obsolete_lang" => ProjectUpgradeEligibilityResponseValidationErrorVariant3Type.FunctionUsingObsoleteLang,
                _ => null,
            };
        }
    }
}