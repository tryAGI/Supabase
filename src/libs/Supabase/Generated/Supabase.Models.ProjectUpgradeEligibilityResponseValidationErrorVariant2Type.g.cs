
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseValidationErrorVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        IndexesReferencingLlToEarth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseValidationErrorVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseValidationErrorVariant2Type value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseValidationErrorVariant2Type.IndexesReferencingLlToEarth => "indexes_referencing_ll_to_earth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseValidationErrorVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "indexes_referencing_ll_to_earth" => ProjectUpgradeEligibilityResponseValidationErrorVariant2Type.IndexesReferencingLlToEarth,
                _ => null,
            };
        }
    }
}