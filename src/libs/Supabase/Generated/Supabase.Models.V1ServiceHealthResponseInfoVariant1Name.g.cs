
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1ServiceHealthResponseInfoVariant1Name
    {
        /// <summary>
        /// 
        /// </summary>
        GoTrue,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1ServiceHealthResponseInfoVariant1NameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ServiceHealthResponseInfoVariant1Name value)
        {
            return value switch
            {
                V1ServiceHealthResponseInfoVariant1Name.GoTrue => "GoTrue",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ServiceHealthResponseInfoVariant1Name? ToEnum(string value)
        {
            return value switch
            {
                "GoTrue" => V1ServiceHealthResponseInfoVariant1Name.GoTrue,
                _ => null,
            };
        }
    }
}