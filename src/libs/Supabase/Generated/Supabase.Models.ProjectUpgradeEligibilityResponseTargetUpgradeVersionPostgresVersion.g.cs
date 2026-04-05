
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseTargetUpgradeVersionPostgresVersion
    {
        /// <summary>
        /// 
        /// </summary>
        x13,
        /// <summary>
        /// 
        /// </summary>
        x14,
        /// <summary>
        /// 
        /// </summary>
        x15,
        /// <summary>
        /// 
        /// </summary>
        x17,
        /// <summary>
        /// 
        /// </summary>
        x17Oriole,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseTargetUpgradeVersionPostgresVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseTargetUpgradeVersionPostgresVersion value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseTargetUpgradeVersionPostgresVersion.x13 => "13",
                ProjectUpgradeEligibilityResponseTargetUpgradeVersionPostgresVersion.x14 => "14",
                ProjectUpgradeEligibilityResponseTargetUpgradeVersionPostgresVersion.x15 => "15",
                ProjectUpgradeEligibilityResponseTargetUpgradeVersionPostgresVersion.x17 => "17",
                ProjectUpgradeEligibilityResponseTargetUpgradeVersionPostgresVersion.x17Oriole => "17-oriole",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseTargetUpgradeVersionPostgresVersion? ToEnum(string value)
        {
            return value switch
            {
                "13" => ProjectUpgradeEligibilityResponseTargetUpgradeVersionPostgresVersion.x13,
                "14" => ProjectUpgradeEligibilityResponseTargetUpgradeVersionPostgresVersion.x14,
                "15" => ProjectUpgradeEligibilityResponseTargetUpgradeVersionPostgresVersion.x15,
                "17" => ProjectUpgradeEligibilityResponseTargetUpgradeVersionPostgresVersion.x17,
                "17-oriole" => ProjectUpgradeEligibilityResponseTargetUpgradeVersionPostgresVersion.x17Oriole,
                _ => null,
            };
        }
    }
}