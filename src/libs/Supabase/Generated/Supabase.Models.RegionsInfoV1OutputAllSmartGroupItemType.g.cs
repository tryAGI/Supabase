
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum RegionsInfoV1OutputAllSmartGroupItemType
    {
        /// <summary>
        ///
        /// </summary>
        SmartGroup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegionsInfoV1OutputAllSmartGroupItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoV1OutputAllSmartGroupItemType value)
        {
            return value switch
            {
                RegionsInfoV1OutputAllSmartGroupItemType.SmartGroup => "smartGroup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoV1OutputAllSmartGroupItemType? ToEnum(string value)
        {
            return value switch
            {
                "smartGroup" => RegionsInfoV1OutputAllSmartGroupItemType.SmartGroup,
                _ => null,
            };
        }
    }
}