
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseCurrentAppVersionReleaseChannel
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
    public static class ProjectUpgradeEligibilityResponseCurrentAppVersionReleaseChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseCurrentAppVersionReleaseChannel value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseCurrentAppVersionReleaseChannel.Alpha => "alpha",
                ProjectUpgradeEligibilityResponseCurrentAppVersionReleaseChannel.Beta => "beta",
                ProjectUpgradeEligibilityResponseCurrentAppVersionReleaseChannel.Ga => "ga",
                ProjectUpgradeEligibilityResponseCurrentAppVersionReleaseChannel.Internal => "internal",
                ProjectUpgradeEligibilityResponseCurrentAppVersionReleaseChannel.Preview => "preview",
                ProjectUpgradeEligibilityResponseCurrentAppVersionReleaseChannel.Withdrawn => "withdrawn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseCurrentAppVersionReleaseChannel? ToEnum(string value)
        {
            return value switch
            {
                "alpha" => ProjectUpgradeEligibilityResponseCurrentAppVersionReleaseChannel.Alpha,
                "beta" => ProjectUpgradeEligibilityResponseCurrentAppVersionReleaseChannel.Beta,
                "ga" => ProjectUpgradeEligibilityResponseCurrentAppVersionReleaseChannel.Ga,
                "internal" => ProjectUpgradeEligibilityResponseCurrentAppVersionReleaseChannel.Internal,
                "preview" => ProjectUpgradeEligibilityResponseCurrentAppVersionReleaseChannel.Preview,
                "withdrawn" => ProjectUpgradeEligibilityResponseCurrentAppVersionReleaseChannel.Withdrawn,
                _ => null,
            };
        }
    }
}