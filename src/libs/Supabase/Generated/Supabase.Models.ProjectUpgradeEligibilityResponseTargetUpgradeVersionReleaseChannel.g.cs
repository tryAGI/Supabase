
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseTargetUpgradeVersionReleaseChannel
    {
        /// <summary>
        /// 
        /// </summary>
        Alpha,
        /// <summary>
        /// 
        /// </summary>
        Beta,
        /// <summary>
        /// 
        /// </summary>
        Ga,
        /// <summary>
        /// 
        /// </summary>
        Internal,
        /// <summary>
        /// 
        /// </summary>
        Preview,
        /// <summary>
        /// 
        /// </summary>
        Withdrawn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseTargetUpgradeVersionReleaseChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseTargetUpgradeVersionReleaseChannel value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseTargetUpgradeVersionReleaseChannel.Alpha => "alpha",
                ProjectUpgradeEligibilityResponseTargetUpgradeVersionReleaseChannel.Beta => "beta",
                ProjectUpgradeEligibilityResponseTargetUpgradeVersionReleaseChannel.Ga => "ga",
                ProjectUpgradeEligibilityResponseTargetUpgradeVersionReleaseChannel.Internal => "internal",
                ProjectUpgradeEligibilityResponseTargetUpgradeVersionReleaseChannel.Preview => "preview",
                ProjectUpgradeEligibilityResponseTargetUpgradeVersionReleaseChannel.Withdrawn => "withdrawn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseTargetUpgradeVersionReleaseChannel? ToEnum(string value)
        {
            return value switch
            {
                "alpha" => ProjectUpgradeEligibilityResponseTargetUpgradeVersionReleaseChannel.Alpha,
                "beta" => ProjectUpgradeEligibilityResponseTargetUpgradeVersionReleaseChannel.Beta,
                "ga" => ProjectUpgradeEligibilityResponseTargetUpgradeVersionReleaseChannel.Ga,
                "internal" => ProjectUpgradeEligibilityResponseTargetUpgradeVersionReleaseChannel.Internal,
                "preview" => ProjectUpgradeEligibilityResponseTargetUpgradeVersionReleaseChannel.Preview,
                "withdrawn" => ProjectUpgradeEligibilityResponseTargetUpgradeVersionReleaseChannel.Withdrawn,
                _ => null,
            };
        }
    }
}