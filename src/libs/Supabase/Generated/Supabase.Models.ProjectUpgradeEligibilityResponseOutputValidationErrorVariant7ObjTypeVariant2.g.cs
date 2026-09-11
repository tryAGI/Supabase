
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7ObjTypeVariant2
    {
        /// <summary>
        ///
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7ObjTypeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7ObjTypeVariant2 value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7ObjTypeVariant2.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7ObjTypeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "function" => ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7ObjTypeVariant2.Function,
                _ => null,
            };
        }
    }
}