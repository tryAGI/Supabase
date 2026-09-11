
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseOutputValidationErrorVariant4Type
    {
        /// <summary>
        ///
        /// </summary>
        UnsupportedExtension,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseOutputValidationErrorVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseOutputValidationErrorVariant4Type value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseOutputValidationErrorVariant4Type.UnsupportedExtension => "unsupported_extension",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseOutputValidationErrorVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "unsupported_extension" => ProjectUpgradeEligibilityResponseOutputValidationErrorVariant4Type.UnsupportedExtension,
                _ => null,
            };
        }
    }
}