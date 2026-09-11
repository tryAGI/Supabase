
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ListProjectAddonsResponseOutputAvailableAddonVariantPriceType
    {
        /// <summary>
        ///
        /// </summary>
        Fixed,
        /// <summary>
        ///
        /// </summary>
        Usage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectAddonsResponseOutputAvailableAddonVariantPriceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectAddonsResponseOutputAvailableAddonVariantPriceType value)
        {
            return value switch
            {
                ListProjectAddonsResponseOutputAvailableAddonVariantPriceType.Fixed => "fixed",
                ListProjectAddonsResponseOutputAvailableAddonVariantPriceType.Usage => "usage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectAddonsResponseOutputAvailableAddonVariantPriceType? ToEnum(string value)
        {
            return value switch
            {
                "fixed" => ListProjectAddonsResponseOutputAvailableAddonVariantPriceType.Fixed,
                "usage" => ListProjectAddonsResponseOutputAvailableAddonVariantPriceType.Usage,
                _ => null,
            };
        }
    }
}