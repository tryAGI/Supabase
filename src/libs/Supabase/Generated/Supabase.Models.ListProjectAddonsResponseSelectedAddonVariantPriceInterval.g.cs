
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListProjectAddonsResponseSelectedAddonVariantPriceInterval
    {
        /// <summary>
        /// 
        /// </summary>
        Hourly,
        /// <summary>
        /// 
        /// </summary>
        Monthly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectAddonsResponseSelectedAddonVariantPriceIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectAddonsResponseSelectedAddonVariantPriceInterval value)
        {
            return value switch
            {
                ListProjectAddonsResponseSelectedAddonVariantPriceInterval.Hourly => "hourly",
                ListProjectAddonsResponseSelectedAddonVariantPriceInterval.Monthly => "monthly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectAddonsResponseSelectedAddonVariantPriceInterval? ToEnum(string value)
        {
            return value switch
            {
                "hourly" => ListProjectAddonsResponseSelectedAddonVariantPriceInterval.Hourly,
                "monthly" => ListProjectAddonsResponseSelectedAddonVariantPriceInterval.Monthly,
                _ => null,
            };
        }
    }
}