
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum NetworkRestrictionsV2ResponseStatus
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
    public static class NetworkRestrictionsV2ResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NetworkRestrictionsV2ResponseStatus value)
        {
            return value switch
            {
                NetworkRestrictionsV2ResponseStatus.Applied => "applied",
                NetworkRestrictionsV2ResponseStatus.Stored => "stored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NetworkRestrictionsV2ResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "applied" => NetworkRestrictionsV2ResponseStatus.Applied,
                "stored" => NetworkRestrictionsV2ResponseStatus.Stored,
                _ => null,
            };
        }
    }
}