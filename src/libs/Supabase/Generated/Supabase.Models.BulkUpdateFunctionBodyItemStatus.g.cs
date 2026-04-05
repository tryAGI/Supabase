
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum BulkUpdateFunctionBodyItemStatus
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
    public static class BulkUpdateFunctionBodyItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkUpdateFunctionBodyItemStatus value)
        {
            return value switch
            {
                BulkUpdateFunctionBodyItemStatus.Active => "ACTIVE",
                BulkUpdateFunctionBodyItemStatus.Removed => "REMOVED",
                BulkUpdateFunctionBodyItemStatus.Throttled => "THROTTLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkUpdateFunctionBodyItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => BulkUpdateFunctionBodyItemStatus.Active,
                "REMOVED" => BulkUpdateFunctionBodyItemStatus.Removed,
                "THROTTLED" => BulkUpdateFunctionBodyItemStatus.Throttled,
                _ => null,
            };
        }
    }
}