
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum RegionsInfoOutputAllSmartGroupItemType
    {
        /// <summary>
        ///
        /// </summary>
        SmartGroup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegionsInfoOutputAllSmartGroupItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoOutputAllSmartGroupItemType value)
        {
            return value switch
            {
                RegionsInfoOutputAllSmartGroupItemType.SmartGroup => "smartGroup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoOutputAllSmartGroupItemType? ToEnum(string value)
        {
            return value switch
            {
                "smartGroup" => RegionsInfoOutputAllSmartGroupItemType.SmartGroup,
                _ => null,
            };
        }
    }
}