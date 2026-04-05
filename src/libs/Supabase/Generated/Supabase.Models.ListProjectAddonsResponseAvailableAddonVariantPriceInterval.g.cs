
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListProjectAddonsResponseAvailableAddonVariantPriceInterval
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
    public static class ListProjectAddonsResponseAvailableAddonVariantPriceIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectAddonsResponseAvailableAddonVariantPriceInterval value)
        {
            return value switch
            {
                ListProjectAddonsResponseAvailableAddonVariantPriceInterval.Hourly => "hourly",
                ListProjectAddonsResponseAvailableAddonVariantPriceInterval.Monthly => "monthly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectAddonsResponseAvailableAddonVariantPriceInterval? ToEnum(string value)
        {
            return value switch
            {
                "hourly" => ListProjectAddonsResponseAvailableAddonVariantPriceInterval.Hourly,
                "monthly" => ListProjectAddonsResponseAvailableAddonVariantPriceInterval.Monthly,
                _ => null,
            };
        }
    }
}