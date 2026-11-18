
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseOutputWarningVariant5Type
    {
        /// <summary>
        ///
        /// </summary>
        CollationReindexRequired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseOutputWarningVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseOutputWarningVariant5Type value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseOutputWarningVariant5Type.CollationReindexRequired => "collation_reindex_required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseOutputWarningVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "collation_reindex_required" => ProjectUpgradeEligibilityResponseOutputWarningVariant5Type.CollationReindexRequired,
                _ => null,
            };
        }
    }
}