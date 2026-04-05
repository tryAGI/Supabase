
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum BranchDeleteResponseMessage
    {
        /// <summary>
        /// 
        /// </summary>
        Ok,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BranchDeleteResponseMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BranchDeleteResponseMessage value)
        {
            return value switch
            {
                BranchDeleteResponseMessage.Ok => "ok",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BranchDeleteResponseMessage? ToEnum(string value)
        {
            return value switch
            {
                "ok" => BranchDeleteResponseMessage.Ok,
                _ => null,
            };
        }
    }
}