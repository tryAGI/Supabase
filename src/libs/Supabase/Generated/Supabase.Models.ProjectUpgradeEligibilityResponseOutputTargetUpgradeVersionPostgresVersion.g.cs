
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionPostgresVersion
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
    public static class ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionPostgresVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionPostgresVersion value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionPostgresVersion.x13 => "13",
                ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionPostgresVersion.x14 => "14",
                ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionPostgresVersion.x15 => "15",
                ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionPostgresVersion.x17 => "17",
                ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionPostgresVersion.x17Oriole => "17-oriole",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionPostgresVersion? ToEnum(string value)
        {
            return value switch
            {
                "13" => ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionPostgresVersion.x13,
                "14" => ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionPostgresVersion.x14,
                "15" => ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionPostgresVersion.x15,
                "17" => ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionPostgresVersion.x17,
                "17-oriole" => ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionPostgresVersion.x17Oriole,
                _ => null,
            };
        }
    }
}