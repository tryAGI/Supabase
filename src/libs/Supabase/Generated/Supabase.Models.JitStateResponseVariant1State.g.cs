
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum JitStateResponseVariant1State
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
    public static class JitStateResponseVariant1StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JitStateResponseVariant1State value)
        {
            return value switch
            {
                JitStateResponseVariant1State.Disabled => "disabled",
                JitStateResponseVariant1State.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JitStateResponseVariant1State? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => JitStateResponseVariant1State.Disabled,
                "enabled" => JitStateResponseVariant1State.Enabled,
                _ => null,
            };
        }
    }
}