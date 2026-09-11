
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ListProjectAddonsResponseOutputAvailableAddonVariantPriceInterval
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
    public static class ListProjectAddonsResponseOutputAvailableAddonVariantPriceIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectAddonsResponseOutputAvailableAddonVariantPriceInterval value)
        {
            return value switch
            {
                ListProjectAddonsResponseOutputAvailableAddonVariantPriceInterval.Hourly => "hourly",
                ListProjectAddonsResponseOutputAvailableAddonVariantPriceInterval.Monthly => "monthly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectAddonsResponseOutputAvailableAddonVariantPriceInterval? ToEnum(string value)
        {
            return value switch
            {
                "hourly" => ListProjectAddonsResponseOutputAvailableAddonVariantPriceInterval.Hourly,
                "monthly" => ListProjectAddonsResponseOutputAvailableAddonVariantPriceInterval.Monthly,
                _ => null,
            };
        }
    }
}