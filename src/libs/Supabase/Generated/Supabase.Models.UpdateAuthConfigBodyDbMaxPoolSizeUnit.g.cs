
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateAuthConfigBodyDbMaxPoolSizeUnit
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
    public static class UpdateAuthConfigBodyDbMaxPoolSizeUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAuthConfigBodyDbMaxPoolSizeUnit value)
        {
            return value switch
            {
                UpdateAuthConfigBodyDbMaxPoolSizeUnit.Connections => "connections",
                UpdateAuthConfigBodyDbMaxPoolSizeUnit.Percent => "percent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAuthConfigBodyDbMaxPoolSizeUnit? ToEnum(string value)
        {
            return value switch
            {
                "connections" => UpdateAuthConfigBodyDbMaxPoolSizeUnit.Connections,
                "percent" => UpdateAuthConfigBodyDbMaxPoolSizeUnit.Percent,
                _ => null,
            };
        }
    }
}