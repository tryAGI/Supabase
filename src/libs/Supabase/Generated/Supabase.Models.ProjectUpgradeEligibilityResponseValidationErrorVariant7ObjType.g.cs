
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseValidationErrorVariant7ObjType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
        /// <summary>
        /// 
        /// </summary>
        Table,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseValidationErrorVariant7ObjTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseValidationErrorVariant7ObjType value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseValidationErrorVariant7ObjType.Function => "function",
                ProjectUpgradeEligibilityResponseValidationErrorVariant7ObjType.Table => "table",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseValidationErrorVariant7ObjType? ToEnum(string value)
        {
            return value switch
            {
                "function" => ProjectUpgradeEligibilityResponseValidationErrorVariant7ObjType.Function,
                "table" => ProjectUpgradeEligibilityResponseValidationErrorVariant7ObjType.Table,
                _ => null,
            };
        }
    }
}