
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum V1OrganizationSlugResponseOutputAllowedReleaseChannel
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
    public static class V1OrganizationSlugResponseOutputAllowedReleaseChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1OrganizationSlugResponseOutputAllowedReleaseChannel value)
        {
            return value switch
            {
                V1OrganizationSlugResponseOutputAllowedReleaseChannel.Alpha => "alpha",
                V1OrganizationSlugResponseOutputAllowedReleaseChannel.Beta => "beta",
                V1OrganizationSlugResponseOutputAllowedReleaseChannel.Ga => "ga",
                V1OrganizationSlugResponseOutputAllowedReleaseChannel.Internal => "internal",
                V1OrganizationSlugResponseOutputAllowedReleaseChannel.Preview => "preview",
                V1OrganizationSlugResponseOutputAllowedReleaseChannel.Withdrawn => "withdrawn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1OrganizationSlugResponseOutputAllowedReleaseChannel? ToEnum(string value)
        {
            return value switch
            {
                "alpha" => V1OrganizationSlugResponseOutputAllowedReleaseChannel.Alpha,
                "beta" => V1OrganizationSlugResponseOutputAllowedReleaseChannel.Beta,
                "ga" => V1OrganizationSlugResponseOutputAllowedReleaseChannel.Ga,
                "internal" => V1OrganizationSlugResponseOutputAllowedReleaseChannel.Internal,
                "preview" => V1OrganizationSlugResponseOutputAllowedReleaseChannel.Preview,
                "withdrawn" => V1OrganizationSlugResponseOutputAllowedReleaseChannel.Withdrawn,
                _ => null,
            };
        }
    }
}