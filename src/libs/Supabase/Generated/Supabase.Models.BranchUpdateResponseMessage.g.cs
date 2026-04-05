
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum BranchUpdateResponseMessage
    {
        /// <summary>
        /// 
        /// </summary>
        Ok,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BranchUpdateResponseMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BranchUpdateResponseMessage value)
        {
            return value switch
            {
                BranchUpdateResponseMessage.Ok => "ok",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BranchUpdateResponseMessage? ToEnum(string value)
        {
            return value switch
            {
                "ok" => BranchUpdateResponseMessage.Ok,
                _ => null,
            };
        }
    }
}