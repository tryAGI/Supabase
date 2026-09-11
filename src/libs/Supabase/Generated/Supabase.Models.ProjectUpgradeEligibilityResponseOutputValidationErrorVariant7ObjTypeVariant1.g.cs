
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7ObjTypeVariant1
    {
        /// <summary>
        ///
        /// </summary>
        Table,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7ObjTypeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7ObjTypeVariant1 value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7ObjTypeVariant1.Table => "table",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7ObjTypeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "table" => ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7ObjTypeVariant1.Table,
                _ => null,
            };
        }
    }
}