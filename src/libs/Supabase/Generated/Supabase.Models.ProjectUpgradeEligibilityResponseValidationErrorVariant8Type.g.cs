
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseValidationErrorVariant8Type
    {
        /// <summary>
        /// 
        /// </summary>
        ActiveReplicationSlot,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseValidationErrorVariant8TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseValidationErrorVariant8Type value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseValidationErrorVariant8Type.ActiveReplicationSlot => "active_replication_slot",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseValidationErrorVariant8Type? ToEnum(string value)
        {
            return value switch
            {
                "active_replication_slot" => ProjectUpgradeEligibilityResponseValidationErrorVariant8Type.ActiveReplicationSlot,
                _ => null,
            };
        }
    }
}