
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseOutputValidationErrorVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        IndexesReferencingLlToEarth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseOutputValidationErrorVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseOutputValidationErrorVariant2Type value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseOutputValidationErrorVariant2Type.IndexesReferencingLlToEarth => "indexes_referencing_ll_to_earth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseOutputValidationErrorVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "indexes_referencing_ll_to_earth" => ProjectUpgradeEligibilityResponseOutputValidationErrorVariant2Type.IndexesReferencingLlToEarth,
                _ => null,
            };
        }
    }
}