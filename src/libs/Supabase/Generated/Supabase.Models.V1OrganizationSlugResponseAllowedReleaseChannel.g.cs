
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1OrganizationSlugResponseAllowedReleaseChannel
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
    public static class V1OrganizationSlugResponseAllowedReleaseChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1OrganizationSlugResponseAllowedReleaseChannel value)
        {
            return value switch
            {
                V1OrganizationSlugResponseAllowedReleaseChannel.Alpha => "alpha",
                V1OrganizationSlugResponseAllowedReleaseChannel.Beta => "beta",
                V1OrganizationSlugResponseAllowedReleaseChannel.Ga => "ga",
                V1OrganizationSlugResponseAllowedReleaseChannel.Internal => "internal",
                V1OrganizationSlugResponseAllowedReleaseChannel.Preview => "preview",
                V1OrganizationSlugResponseAllowedReleaseChannel.Withdrawn => "withdrawn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1OrganizationSlugResponseAllowedReleaseChannel? ToEnum(string value)
        {
            return value switch
            {
                "alpha" => V1OrganizationSlugResponseAllowedReleaseChannel.Alpha,
                "beta" => V1OrganizationSlugResponseAllowedReleaseChannel.Beta,
                "ga" => V1OrganizationSlugResponseAllowedReleaseChannel.Ga,
                "internal" => V1OrganizationSlugResponseAllowedReleaseChannel.Internal,
                "preview" => V1OrganizationSlugResponseAllowedReleaseChannel.Preview,
                "withdrawn" => V1OrganizationSlugResponseAllowedReleaseChannel.Withdrawn,
                _ => null,
            };
        }
    }
}