
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum AuthConfigResponseOutputDbMaxPoolSizeUnit
    {
        /// <summary>
        ///
        /// </summary>
        Connections,
        /// <summary>
        ///
        /// </summary>
        Percent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthConfigResponseOutputDbMaxPoolSizeUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthConfigResponseOutputDbMaxPoolSizeUnit value)
        {
            return value switch
            {
                AuthConfigResponseOutputDbMaxPoolSizeUnit.Connections => "connections",
                AuthConfigResponseOutputDbMaxPoolSizeUnit.Percent => "percent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthConfigResponseOutputDbMaxPoolSizeUnit? ToEnum(string value)
        {
            return value switch
            {
                "connections" => AuthConfigResponseOutputDbMaxPoolSizeUnit.Connections,
                "percent" => AuthConfigResponseOutputDbMaxPoolSizeUnit.Percent,
                _ => null,
            };
        }
    }
}