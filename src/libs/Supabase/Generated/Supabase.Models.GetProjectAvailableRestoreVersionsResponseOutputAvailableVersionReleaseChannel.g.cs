
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionReleaseChannel
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
    public static class GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionReleaseChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionReleaseChannel value)
        {
            return value switch
            {
                GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionReleaseChannel.Alpha => "alpha",
                GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionReleaseChannel.Beta => "beta",
                GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionReleaseChannel.Ga => "ga",
                GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionReleaseChannel.Internal => "internal",
                GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionReleaseChannel.Preview => "preview",
                GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionReleaseChannel.Withdrawn => "withdrawn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionReleaseChannel? ToEnum(string value)
        {
            return value switch
            {
                "alpha" => GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionReleaseChannel.Alpha,
                "beta" => GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionReleaseChannel.Beta,
                "ga" => GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionReleaseChannel.Ga,
                "internal" => GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionReleaseChannel.Internal,
                "preview" => GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionReleaseChannel.Preview,
                "withdrawn" => GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionReleaseChannel.Withdrawn,
                _ => null,
            };
        }
    }
}