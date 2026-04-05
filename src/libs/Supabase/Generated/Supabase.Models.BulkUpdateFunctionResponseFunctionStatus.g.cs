
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum BulkUpdateFunctionResponseFunctionStatus
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
    public static class BulkUpdateFunctionResponseFunctionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkUpdateFunctionResponseFunctionStatus value)
        {
            return value switch
            {
                BulkUpdateFunctionResponseFunctionStatus.Active => "ACTIVE",
                BulkUpdateFunctionResponseFunctionStatus.Removed => "REMOVED",
                BulkUpdateFunctionResponseFunctionStatus.Throttled => "THROTTLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkUpdateFunctionResponseFunctionStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => BulkUpdateFunctionResponseFunctionStatus.Active,
                "REMOVED" => BulkUpdateFunctionResponseFunctionStatus.Removed,
                "THROTTLED" => BulkUpdateFunctionResponseFunctionStatus.Throttled,
                _ => null,
            };
        }
    }
}