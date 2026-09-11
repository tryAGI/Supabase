
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum BulkUpdateFunctionResponseOutputFunctionStatus
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Removed,
        /// <summary>
        ///
        /// </summary>
        Throttled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BulkUpdateFunctionResponseOutputFunctionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkUpdateFunctionResponseOutputFunctionStatus value)
        {
            return value switch
            {
                BulkUpdateFunctionResponseOutputFunctionStatus.Active => "ACTIVE",
                BulkUpdateFunctionResponseOutputFunctionStatus.Removed => "REMOVED",
                BulkUpdateFunctionResponseOutputFunctionStatus.Throttled => "THROTTLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkUpdateFunctionResponseOutputFunctionStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => BulkUpdateFunctionResponseOutputFunctionStatus.Active,
                "REMOVED" => BulkUpdateFunctionResponseOutputFunctionStatus.Removed,
                "THROTTLED" => BulkUpdateFunctionResponseOutputFunctionStatus.Throttled,
                _ => null,
            };
        }
    }
}