
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseValidationErrorVariant7ObjTypeVariant1
    {
        /// <summary>
        ///
        /// </summary>
        Table,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseValidationErrorVariant7ObjTypeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseValidationErrorVariant7ObjTypeVariant1 value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseValidationErrorVariant7ObjTypeVariant1.Table => "table",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseValidationErrorVariant7ObjTypeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "table" => ProjectUpgradeEligibilityResponseValidationErrorVariant7ObjTypeVariant1.Table,
                _ => null,
            };
        }
    }
}