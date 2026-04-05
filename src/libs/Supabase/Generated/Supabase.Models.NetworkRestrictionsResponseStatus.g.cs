
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum NetworkRestrictionsResponseStatus
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
    public static class NetworkRestrictionsResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NetworkRestrictionsResponseStatus value)
        {
            return value switch
            {
                NetworkRestrictionsResponseStatus.Applied => "applied",
                NetworkRestrictionsResponseStatus.Stored => "stored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NetworkRestrictionsResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "applied" => NetworkRestrictionsResponseStatus.Applied,
                "stored" => NetworkRestrictionsResponseStatus.Stored,
                _ => null,
            };
        }
    }
}