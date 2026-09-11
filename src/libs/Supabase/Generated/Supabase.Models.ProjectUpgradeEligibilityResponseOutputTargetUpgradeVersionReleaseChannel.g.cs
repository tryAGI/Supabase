
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionReleaseChannel
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
    public static class ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionReleaseChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionReleaseChannel value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionReleaseChannel.Alpha => "alpha",
                ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionReleaseChannel.Beta => "beta",
                ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionReleaseChannel.Ga => "ga",
                ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionReleaseChannel.Internal => "internal",
                ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionReleaseChannel.Preview => "preview",
                ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionReleaseChannel.Withdrawn => "withdrawn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionReleaseChannel? ToEnum(string value)
        {
            return value switch
            {
                "alpha" => ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionReleaseChannel.Alpha,
                "beta" => ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionReleaseChannel.Beta,
                "ga" => ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionReleaseChannel.Ga,
                "internal" => ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionReleaseChannel.Internal,
                "preview" => ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionReleaseChannel.Preview,
                "withdrawn" => ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionReleaseChannel.Withdrawn,
                _ => null,
            };
        }
    }
}