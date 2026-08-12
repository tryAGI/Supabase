
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1UpdateJitAccessConfigResponseVariant1State
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
    public static class V1UpdateJitAccessConfigResponseVariant1StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1UpdateJitAccessConfigResponseVariant1State value)
        {
            return value switch
            {
                V1UpdateJitAccessConfigResponseVariant1State.Disabled => "disabled",
                V1UpdateJitAccessConfigResponseVariant1State.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1UpdateJitAccessConfigResponseVariant1State? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => V1UpdateJitAccessConfigResponseVariant1State.Disabled,
                "enabled" => V1UpdateJitAccessConfigResponseVariant1State.Enabled,
                _ => null,
            };
        }
    }
}