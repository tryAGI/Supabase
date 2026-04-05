
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseValidationErrorVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        UnsupportedExtension,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseValidationErrorVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseValidationErrorVariant4Type value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseValidationErrorVariant4Type.UnsupportedExtension => "unsupported_extension",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseValidationErrorVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "unsupported_extension" => ProjectUpgradeEligibilityResponseValidationErrorVariant4Type.UnsupportedExtension,
                _ => null,
            };
        }
    }
}