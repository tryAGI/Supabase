
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ListProjectAddonsResponseOutputSelectedAddonVariantPriceInterval
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
    public static class ListProjectAddonsResponseOutputSelectedAddonVariantPriceIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectAddonsResponseOutputSelectedAddonVariantPriceInterval value)
        {
            return value switch
            {
                ListProjectAddonsResponseOutputSelectedAddonVariantPriceInterval.Hourly => "hourly",
                ListProjectAddonsResponseOutputSelectedAddonVariantPriceInterval.Monthly => "monthly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectAddonsResponseOutputSelectedAddonVariantPriceInterval? ToEnum(string value)
        {
            return value switch
            {
                "hourly" => ListProjectAddonsResponseOutputSelectedAddonVariantPriceInterval.Hourly,
                "monthly" => ListProjectAddonsResponseOutputSelectedAddonVariantPriceInterval.Monthly,
                _ => null,
            };
        }
    }
}