
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum RegionsInfoAllSmartGroupItemType
    {
        /// <summary>
        /// 
        /// </summary>
        SmartGroup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegionsInfoAllSmartGroupItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoAllSmartGroupItemType value)
        {
            return value switch
            {
                RegionsInfoAllSmartGroupItemType.SmartGroup => "smartGroup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoAllSmartGroupItemType? ToEnum(string value)
        {
            return value switch
            {
                "smartGroup" => RegionsInfoAllSmartGroupItemType.SmartGroup,
                _ => null,
            };
        }
    }
}