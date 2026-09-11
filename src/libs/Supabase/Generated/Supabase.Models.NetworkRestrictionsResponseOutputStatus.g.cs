
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum NetworkRestrictionsResponseOutputStatus
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
    public static class NetworkRestrictionsResponseOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NetworkRestrictionsResponseOutputStatus value)
        {
            return value switch
            {
                NetworkRestrictionsResponseOutputStatus.Applied => "applied",
                NetworkRestrictionsResponseOutputStatus.Stored => "stored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NetworkRestrictionsResponseOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "applied" => NetworkRestrictionsResponseOutputStatus.Applied,
                "stored" => NetworkRestrictionsResponseOutputStatus.Stored,
                _ => null,
            };
        }
    }
}