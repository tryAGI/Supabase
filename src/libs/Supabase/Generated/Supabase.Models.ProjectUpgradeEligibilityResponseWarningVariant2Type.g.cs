
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseWarningVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        LtreeReindexRequired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseWarningVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseWarningVariant2Type value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseWarningVariant2Type.LtreeReindexRequired => "ltree_reindex_required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseWarningVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "ltree_reindex_required" => ProjectUpgradeEligibilityResponseWarningVariant2Type.LtreeReindexRequired,
                _ => null,
            };
        }
    }
}