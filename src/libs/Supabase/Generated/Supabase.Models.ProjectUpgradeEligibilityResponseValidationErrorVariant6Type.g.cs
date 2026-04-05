
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseValidationErrorVariant6Type
    {
        /// <summary>
        /// 
        /// </summary>
        UnloggedTableWithPersistentSequence,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseValidationErrorVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseValidationErrorVariant6Type value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseValidationErrorVariant6Type.UnloggedTableWithPersistentSequence => "unlogged_table_with_persistent_sequence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseValidationErrorVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "unlogged_table_with_persistent_sequence" => ProjectUpgradeEligibilityResponseValidationErrorVariant6Type.UnloggedTableWithPersistentSequence,
                _ => null,
            };
        }
    }
}