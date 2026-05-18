
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseValidationErrorVariant9Type
    {
        /// <summary>
        /// 
        /// </summary>
        X86Architecture,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseValidationErrorVariant9TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseValidationErrorVariant9Type value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseValidationErrorVariant9Type.X86Architecture => "x86_architecture",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseValidationErrorVariant9Type? ToEnum(string value)
        {
            return value switch
            {
                "x86_architecture" => ProjectUpgradeEligibilityResponseValidationErrorVariant9Type.X86Architecture,
                _ => null,
            };
        }
    }
}