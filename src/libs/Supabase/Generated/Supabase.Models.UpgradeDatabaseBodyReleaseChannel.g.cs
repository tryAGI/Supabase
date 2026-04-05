
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpgradeDatabaseBodyReleaseChannel
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
    public static class UpgradeDatabaseBodyReleaseChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpgradeDatabaseBodyReleaseChannel value)
        {
            return value switch
            {
                UpgradeDatabaseBodyReleaseChannel.Alpha => "alpha",
                UpgradeDatabaseBodyReleaseChannel.Beta => "beta",
                UpgradeDatabaseBodyReleaseChannel.Ga => "ga",
                UpgradeDatabaseBodyReleaseChannel.Internal => "internal",
                UpgradeDatabaseBodyReleaseChannel.Preview => "preview",
                UpgradeDatabaseBodyReleaseChannel.Withdrawn => "withdrawn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpgradeDatabaseBodyReleaseChannel? ToEnum(string value)
        {
            return value switch
            {
                "alpha" => UpgradeDatabaseBodyReleaseChannel.Alpha,
                "beta" => UpgradeDatabaseBodyReleaseChannel.Beta,
                "ga" => UpgradeDatabaseBodyReleaseChannel.Ga,
                "internal" => UpgradeDatabaseBodyReleaseChannel.Internal,
                "preview" => UpgradeDatabaseBodyReleaseChannel.Preview,
                "withdrawn" => UpgradeDatabaseBodyReleaseChannel.Withdrawn,
                _ => null,
            };
        }
    }
}