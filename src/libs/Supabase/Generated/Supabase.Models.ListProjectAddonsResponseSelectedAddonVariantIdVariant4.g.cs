
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListProjectAddonsResponseSelectedAddonVariantIdVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        Ipv4Default,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectAddonsResponseSelectedAddonVariantIdVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectAddonsResponseSelectedAddonVariantIdVariant4 value)
        {
            return value switch
            {
                ListProjectAddonsResponseSelectedAddonVariantIdVariant4.Ipv4Default => "ipv4_default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectAddonsResponseSelectedAddonVariantIdVariant4? ToEnum(string value)
        {
            return value switch
            {
                "ipv4_default" => ListProjectAddonsResponseSelectedAddonVariantIdVariant4.Ipv4Default,
                _ => null,
            };
        }
    }
}