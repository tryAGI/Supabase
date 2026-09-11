
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum BranchDeleteResponseOutputMessage
    {
        /// <summary>
        ///
        /// </summary>
        Ok,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BranchDeleteResponseOutputMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BranchDeleteResponseOutputMessage value)
        {
            return value switch
            {
                BranchDeleteResponseOutputMessage.Ok => "ok",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BranchDeleteResponseOutputMessage? ToEnum(string value)
        {
            return value switch
            {
                "ok" => BranchDeleteResponseOutputMessage.Ok,
                _ => null,
            };
        }
    }
}