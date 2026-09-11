
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum BranchUpdateResponseOutputMessage
    {
        /// <summary>
        ///
        /// </summary>
        Ok,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BranchUpdateResponseOutputMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BranchUpdateResponseOutputMessage value)
        {
            return value switch
            {
                BranchUpdateResponseOutputMessage.Ok => "ok",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BranchUpdateResponseOutputMessage? ToEnum(string value)
        {
            return value switch
            {
                "ok" => BranchUpdateResponseOutputMessage.Ok,
                _ => null,
            };
        }
    }
}