
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseOutputCurrentAppVersionReleaseChannel
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
    public static class ProjectUpgradeEligibilityResponseOutputCurrentAppVersionReleaseChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseOutputCurrentAppVersionReleaseChannel value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseOutputCurrentAppVersionReleaseChannel.Alpha => "alpha",
                ProjectUpgradeEligibilityResponseOutputCurrentAppVersionReleaseChannel.Beta => "beta",
                ProjectUpgradeEligibilityResponseOutputCurrentAppVersionReleaseChannel.Ga => "ga",
                ProjectUpgradeEligibilityResponseOutputCurrentAppVersionReleaseChannel.Internal => "internal",
                ProjectUpgradeEligibilityResponseOutputCurrentAppVersionReleaseChannel.Preview => "preview",
                ProjectUpgradeEligibilityResponseOutputCurrentAppVersionReleaseChannel.Withdrawn => "withdrawn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseOutputCurrentAppVersionReleaseChannel? ToEnum(string value)
        {
            return value switch
            {
                "alpha" => ProjectUpgradeEligibilityResponseOutputCurrentAppVersionReleaseChannel.Alpha,
                "beta" => ProjectUpgradeEligibilityResponseOutputCurrentAppVersionReleaseChannel.Beta,
                "ga" => ProjectUpgradeEligibilityResponseOutputCurrentAppVersionReleaseChannel.Ga,
                "internal" => ProjectUpgradeEligibilityResponseOutputCurrentAppVersionReleaseChannel.Internal,
                "preview" => ProjectUpgradeEligibilityResponseOutputCurrentAppVersionReleaseChannel.Preview,
                "withdrawn" => ProjectUpgradeEligibilityResponseOutputCurrentAppVersionReleaseChannel.Withdrawn,
                _ => null,
            };
        }
    }
}