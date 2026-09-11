
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum V1ServiceHealthResponseOutputInfoVariant1Name
    {
        /// <summary>
        ///
        /// </summary>
        GoTrue,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1ServiceHealthResponseOutputInfoVariant1NameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ServiceHealthResponseOutputInfoVariant1Name value)
        {
            return value switch
            {
                V1ServiceHealthResponseOutputInfoVariant1Name.GoTrue => "GoTrue",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ServiceHealthResponseOutputInfoVariant1Name? ToEnum(string value)
        {
            return value switch
            {
                "GoTrue" => V1ServiceHealthResponseOutputInfoVariant1Name.GoTrue,
                _ => null,
            };
        }
    }
}