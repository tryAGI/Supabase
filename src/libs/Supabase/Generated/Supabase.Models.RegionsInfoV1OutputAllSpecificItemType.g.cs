
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum RegionsInfoV1OutputAllSpecificItemType
    {
        /// <summary>
        ///
        /// </summary>
        Specific,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegionsInfoV1OutputAllSpecificItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoV1OutputAllSpecificItemType value)
        {
            return value switch
            {
                RegionsInfoV1OutputAllSpecificItemType.Specific => "specific",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoV1OutputAllSpecificItemType? ToEnum(string value)
        {
            return value switch
            {
                "specific" => RegionsInfoV1OutputAllSpecificItemType.Specific,
                _ => null,
            };
        }
    }
}