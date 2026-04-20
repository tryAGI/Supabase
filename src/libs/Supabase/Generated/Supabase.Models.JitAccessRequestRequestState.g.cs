
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum JitAccessRequestRequestState
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
    public static class JitAccessRequestRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JitAccessRequestRequestState value)
        {
            return value switch
            {
                JitAccessRequestRequestState.Disabled => "disabled",
                JitAccessRequestRequestState.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JitAccessRequestRequestState? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => JitAccessRequestRequestState.Disabled,
                "enabled" => JitAccessRequestRequestState.Enabled,
                _ => null,
            };
        }
    }
}