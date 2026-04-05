
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListProjectAddonsResponseSelectedAddonVariantPriceType
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
    public static class ListProjectAddonsResponseSelectedAddonVariantPriceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectAddonsResponseSelectedAddonVariantPriceType value)
        {
            return value switch
            {
                ListProjectAddonsResponseSelectedAddonVariantPriceType.Fixed => "fixed",
                ListProjectAddonsResponseSelectedAddonVariantPriceType.Usage => "usage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectAddonsResponseSelectedAddonVariantPriceType? ToEnum(string value)
        {
            return value switch
            {
                "fixed" => ListProjectAddonsResponseSelectedAddonVariantPriceType.Fixed,
                "usage" => ListProjectAddonsResponseSelectedAddonVariantPriceType.Usage,
                _ => null,
            };
        }
    }
}