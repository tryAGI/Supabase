
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteRolesResponseMessage
    {
        /// <summary>
        /// 
        /// </summary>
        Ok,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteRolesResponseMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteRolesResponseMessage value)
        {
            return value switch
            {
                DeleteRolesResponseMessage.Ok => "ok",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteRolesResponseMessage? ToEnum(string value)
        {
            return value switch
            {
                "ok" => DeleteRolesResponseMessage.Ok,
                _ => null,
            };
        }
    }
}