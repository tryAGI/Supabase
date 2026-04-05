
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectAvailableRestoreVersionsResponseAvailableVersionReleaseChannel
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
    public static class GetProjectAvailableRestoreVersionsResponseAvailableVersionReleaseChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectAvailableRestoreVersionsResponseAvailableVersionReleaseChannel value)
        {
            return value switch
            {
                GetProjectAvailableRestoreVersionsResponseAvailableVersionReleaseChannel.Alpha => "alpha",
                GetProjectAvailableRestoreVersionsResponseAvailableVersionReleaseChannel.Beta => "beta",
                GetProjectAvailableRestoreVersionsResponseAvailableVersionReleaseChannel.Ga => "ga",
                GetProjectAvailableRestoreVersionsResponseAvailableVersionReleaseChannel.Internal => "internal",
                GetProjectAvailableRestoreVersionsResponseAvailableVersionReleaseChannel.Preview => "preview",
                GetProjectAvailableRestoreVersionsResponseAvailableVersionReleaseChannel.Withdrawn => "withdrawn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectAvailableRestoreVersionsResponseAvailableVersionReleaseChannel? ToEnum(string value)
        {
            return value switch
            {
                "alpha" => GetProjectAvailableRestoreVersionsResponseAvailableVersionReleaseChannel.Alpha,
                "beta" => GetProjectAvailableRestoreVersionsResponseAvailableVersionReleaseChannel.Beta,
                "ga" => GetProjectAvailableRestoreVersionsResponseAvailableVersionReleaseChannel.Ga,
                "internal" => GetProjectAvailableRestoreVersionsResponseAvailableVersionReleaseChannel.Internal,
                "preview" => GetProjectAvailableRestoreVersionsResponseAvailableVersionReleaseChannel.Preview,
                "withdrawn" => GetProjectAvailableRestoreVersionsResponseAvailableVersionReleaseChannel.Withdrawn,
                _ => null,
            };
        }
    }
}