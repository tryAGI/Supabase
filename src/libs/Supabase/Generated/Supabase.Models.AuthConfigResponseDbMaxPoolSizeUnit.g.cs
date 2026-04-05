
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthConfigResponseDbMaxPoolSizeUnit
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
    public static class AuthConfigResponseDbMaxPoolSizeUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthConfigResponseDbMaxPoolSizeUnit value)
        {
            return value switch
            {
                AuthConfigResponseDbMaxPoolSizeUnit.Connections => "connections",
                AuthConfigResponseDbMaxPoolSizeUnit.Percent => "percent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthConfigResponseDbMaxPoolSizeUnit? ToEnum(string value)
        {
            return value switch
            {
                "connections" => AuthConfigResponseDbMaxPoolSizeUnit.Connections,
                "percent" => AuthConfigResponseDbMaxPoolSizeUnit.Percent,
                _ => null,
            };
        }
    }
}