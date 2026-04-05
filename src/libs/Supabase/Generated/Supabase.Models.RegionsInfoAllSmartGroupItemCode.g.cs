
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum RegionsInfoAllSmartGroupItemCode
    {
        /// <summary>
        /// 
        /// </summary>
        Americas,
        /// <summary>
        /// 
        /// </summary>
        Apac,
        /// <summary>
        /// 
        /// </summary>
        Emea,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegionsInfoAllSmartGroupItemCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoAllSmartGroupItemCode value)
        {
            return value switch
            {
                RegionsInfoAllSmartGroupItemCode.Americas => "americas",
                RegionsInfoAllSmartGroupItemCode.Apac => "apac",
                RegionsInfoAllSmartGroupItemCode.Emea => "emea",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoAllSmartGroupItemCode? ToEnum(string value)
        {
            return value switch
            {
                "americas" => RegionsInfoAllSmartGroupItemCode.Americas,
                "apac" => RegionsInfoAllSmartGroupItemCode.Apac,
                "emea" => RegionsInfoAllSmartGroupItemCode.Emea,
                _ => null,
            };
        }
    }
}