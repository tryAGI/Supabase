
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum JitStateResponseVariant2State
    {
        /// <summary>
        /// 
        /// </summary>
        Unavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JitStateResponseVariant2StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JitStateResponseVariant2State value)
        {
            return value switch
            {
                JitStateResponseVariant2State.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JitStateResponseVariant2State? ToEnum(string value)
        {
            return value switch
            {
                "unavailable" => JitStateResponseVariant2State.Unavailable,
                _ => null,
            };
        }
    }
}