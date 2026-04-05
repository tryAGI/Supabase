
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum BranchRestoreResponseMessage
    {
        /// <summary>
        /// 
        /// </summary>
        BranchRestorationInitiated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BranchRestoreResponseMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BranchRestoreResponseMessage value)
        {
            return value switch
            {
                BranchRestoreResponseMessage.BranchRestorationInitiated => "Branch restoration initiated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BranchRestoreResponseMessage? ToEnum(string value)
        {
            return value switch
            {
                "Branch restoration initiated" => BranchRestoreResponseMessage.BranchRestorationInitiated,
                _ => null,
            };
        }
    }
}