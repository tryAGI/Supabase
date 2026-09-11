
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum DeleteRolesResponseOutputMessage
    {
        /// <summary>
        ///
        /// </summary>
        Ok,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteRolesResponseOutputMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteRolesResponseOutputMessage value)
        {
            return value switch
            {
                DeleteRolesResponseOutputMessage.Ok => "ok",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteRolesResponseOutputMessage? ToEnum(string value)
        {
            return value switch
            {
                "ok" => DeleteRolesResponseOutputMessage.Ok,
                _ => null,
            };
        }
    }
}