
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum RegionsInfoV1OutputAllSmartGroupItemCode
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
    public static class RegionsInfoV1OutputAllSmartGroupItemCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoV1OutputAllSmartGroupItemCode value)
        {
            return value switch
            {
                RegionsInfoV1OutputAllSmartGroupItemCode.Americas => "americas",
                RegionsInfoV1OutputAllSmartGroupItemCode.Apac => "apac",
                RegionsInfoV1OutputAllSmartGroupItemCode.Emea => "emea",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoV1OutputAllSmartGroupItemCode? ToEnum(string value)
        {
            return value switch
            {
                "americas" => RegionsInfoV1OutputAllSmartGroupItemCode.Americas,
                "apac" => RegionsInfoV1OutputAllSmartGroupItemCode.Apac,
                "emea" => RegionsInfoV1OutputAllSmartGroupItemCode.Emea,
                _ => null,
            };
        }
    }
}