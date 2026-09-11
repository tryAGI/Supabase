
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ListProjectAddonsResponseOutputSelectedAddonVariantPriceType
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
    public static class ListProjectAddonsResponseOutputSelectedAddonVariantPriceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectAddonsResponseOutputSelectedAddonVariantPriceType value)
        {
            return value switch
            {
                ListProjectAddonsResponseOutputSelectedAddonVariantPriceType.Fixed => "fixed",
                ListProjectAddonsResponseOutputSelectedAddonVariantPriceType.Usage => "usage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectAddonsResponseOutputSelectedAddonVariantPriceType? ToEnum(string value)
        {
            return value switch
            {
                "fixed" => ListProjectAddonsResponseOutputSelectedAddonVariantPriceType.Fixed,
                "usage" => ListProjectAddonsResponseOutputSelectedAddonVariantPriceType.Usage,
                _ => null,
            };
        }
    }
}