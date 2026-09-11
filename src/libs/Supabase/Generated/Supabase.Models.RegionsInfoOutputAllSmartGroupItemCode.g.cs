
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum RegionsInfoOutputAllSmartGroupItemCode
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
    public static class RegionsInfoOutputAllSmartGroupItemCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoOutputAllSmartGroupItemCode value)
        {
            return value switch
            {
                RegionsInfoOutputAllSmartGroupItemCode.Americas => "americas",
                RegionsInfoOutputAllSmartGroupItemCode.Apac => "apac",
                RegionsInfoOutputAllSmartGroupItemCode.Emea => "emea",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoOutputAllSmartGroupItemCode? ToEnum(string value)
        {
            return value switch
            {
                "americas" => RegionsInfoOutputAllSmartGroupItemCode.Americas,
                "apac" => RegionsInfoOutputAllSmartGroupItemCode.Apac,
                "emea" => RegionsInfoOutputAllSmartGroupItemCode.Emea,
                _ => null,
            };
        }
    }
}