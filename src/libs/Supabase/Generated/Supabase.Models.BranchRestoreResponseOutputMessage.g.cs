
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum BranchRestoreResponseOutputMessage
    {
        /// <summary>
        ///
        /// </summary>
        BranchRestorationInitiated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BranchRestoreResponseOutputMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BranchRestoreResponseOutputMessage value)
        {
            return value switch
            {
                BranchRestoreResponseOutputMessage.BranchRestorationInitiated => "Branch restoration initiated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BranchRestoreResponseOutputMessage? ToEnum(string value)
        {
            return value switch
            {
                "Branch restoration initiated" => BranchRestoreResponseOutputMessage.BranchRestorationInitiated,
                _ => null,
            };
        }
    }
}