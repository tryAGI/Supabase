
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum RegionsInfoAllSpecificItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Capacity,
        /// <summary>
        /// 
        /// </summary>
        Other,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegionsInfoAllSpecificItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoAllSpecificItemStatus value)
        {
            return value switch
            {
                RegionsInfoAllSpecificItemStatus.Capacity => "capacity",
                RegionsInfoAllSpecificItemStatus.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoAllSpecificItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "capacity" => RegionsInfoAllSpecificItemStatus.Capacity,
                "other" => RegionsInfoAllSpecificItemStatus.Other,
                _ => null,
            };
        }
    }
}