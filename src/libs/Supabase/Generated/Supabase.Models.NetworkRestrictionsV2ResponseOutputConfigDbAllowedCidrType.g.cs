
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum NetworkRestrictionsV2ResponseOutputConfigDbAllowedCidrType
    {
        /// <summary>
        ///
        /// </summary>
        V4,
        /// <summary>
        ///
        /// </summary>
        V6,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NetworkRestrictionsV2ResponseOutputConfigDbAllowedCidrTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NetworkRestrictionsV2ResponseOutputConfigDbAllowedCidrType value)
        {
            return value switch
            {
                NetworkRestrictionsV2ResponseOutputConfigDbAllowedCidrType.V4 => "v4",
                NetworkRestrictionsV2ResponseOutputConfigDbAllowedCidrType.V6 => "v6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NetworkRestrictionsV2ResponseOutputConfigDbAllowedCidrType? ToEnum(string value)
        {
            return value switch
            {
                "v4" => NetworkRestrictionsV2ResponseOutputConfigDbAllowedCidrType.V4,
                "v6" => NetworkRestrictionsV2ResponseOutputConfigDbAllowedCidrType.V6,
                _ => null,
            };
        }
    }
}