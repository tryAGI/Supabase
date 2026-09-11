
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum NetworkRestrictionsV2ResponseOutputStatus
    {
        /// <summary>
        ///
        /// </summary>
        Applied,
        /// <summary>
        ///
        /// </summary>
        Stored,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NetworkRestrictionsV2ResponseOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NetworkRestrictionsV2ResponseOutputStatus value)
        {
            return value switch
            {
                NetworkRestrictionsV2ResponseOutputStatus.Applied => "applied",
                NetworkRestrictionsV2ResponseOutputStatus.Stored => "stored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NetworkRestrictionsV2ResponseOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "applied" => NetworkRestrictionsV2ResponseOutputStatus.Applied,
                "stored" => NetworkRestrictionsV2ResponseOutputStatus.Stored,
                _ => null,
            };
        }
    }
}