
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum JitStateResponseDiscriminatorState
    {
        /// <summary>
        /// 
        /// </summary>
        Unavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JitStateResponseDiscriminatorStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JitStateResponseDiscriminatorState value)
        {
            return value switch
            {
                JitStateResponseDiscriminatorState.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JitStateResponseDiscriminatorState? ToEnum(string value)
        {
            return value switch
            {
                "unavailable" => JitStateResponseDiscriminatorState.Unavailable,
                _ => null,
            };
        }
    }
}