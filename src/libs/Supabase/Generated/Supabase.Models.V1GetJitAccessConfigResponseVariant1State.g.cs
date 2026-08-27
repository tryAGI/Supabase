
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum V1GetJitAccessConfigResponseVariant1State
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1GetJitAccessConfigResponseVariant1StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1GetJitAccessConfigResponseVariant1State value)
        {
            return value switch
            {
                V1GetJitAccessConfigResponseVariant1State.Disabled => "disabled",
                V1GetJitAccessConfigResponseVariant1State.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1GetJitAccessConfigResponseVariant1State? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => V1GetJitAccessConfigResponseVariant1State.Disabled,
                "enabled" => V1GetJitAccessConfigResponseVariant1State.Enabled,
                _ => null,
            };
        }
    }
}