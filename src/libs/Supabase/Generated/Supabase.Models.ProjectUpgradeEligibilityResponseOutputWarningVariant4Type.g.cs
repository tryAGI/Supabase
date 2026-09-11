
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseOutputWarningVariant4Type
    {
        /// <summary>
        ///
        /// </summary>
        BtreeGistNanReindex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseOutputWarningVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseOutputWarningVariant4Type value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseOutputWarningVariant4Type.BtreeGistNanReindex => "btree_gist_nan_reindex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseOutputWarningVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "btree_gist_nan_reindex" => ProjectUpgradeEligibilityResponseOutputWarningVariant4Type.BtreeGistNanReindex,
                _ => null,
            };
        }
    }
}