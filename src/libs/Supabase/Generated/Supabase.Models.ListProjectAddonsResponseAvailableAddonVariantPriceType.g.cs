
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListProjectAddonsResponseAvailableAddonVariantPriceType
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
    public static class ListProjectAddonsResponseAvailableAddonVariantPriceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectAddonsResponseAvailableAddonVariantPriceType value)
        {
            return value switch
            {
                ListProjectAddonsResponseAvailableAddonVariantPriceType.Fixed => "fixed",
                ListProjectAddonsResponseAvailableAddonVariantPriceType.Usage => "usage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectAddonsResponseAvailableAddonVariantPriceType? ToEnum(string value)
        {
            return value switch
            {
                "fixed" => ListProjectAddonsResponseAvailableAddonVariantPriceType.Fixed,
                "usage" => ListProjectAddonsResponseAvailableAddonVariantPriceType.Usage,
                _ => null,
            };
        }
    }
}