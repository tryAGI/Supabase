
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum RegionsInfoAllSpecificItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Specific,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegionsInfoAllSpecificItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoAllSpecificItemType value)
        {
            return value switch
            {
                RegionsInfoAllSpecificItemType.Specific => "specific",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoAllSpecificItemType? ToEnum(string value)
        {
            return value switch
            {
                "specific" => RegionsInfoAllSpecificItemType.Specific,
                _ => null,
            };
        }
    }
}