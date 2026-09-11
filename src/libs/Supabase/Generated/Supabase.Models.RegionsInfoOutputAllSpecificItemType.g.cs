
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum RegionsInfoOutputAllSpecificItemType
    {
        /// <summary>
        ///
        /// </summary>
        Specific,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegionsInfoOutputAllSpecificItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoOutputAllSpecificItemType value)
        {
            return value switch
            {
                RegionsInfoOutputAllSpecificItemType.Specific => "specific",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoOutputAllSpecificItemType? ToEnum(string value)
        {
            return value switch
            {
                "specific" => RegionsInfoOutputAllSpecificItemType.Specific,
                _ => null,
            };
        }
    }
}