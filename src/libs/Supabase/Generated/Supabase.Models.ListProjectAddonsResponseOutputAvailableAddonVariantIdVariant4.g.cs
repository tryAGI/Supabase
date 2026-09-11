
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant4
    {
        /// <summary>
        ///
        /// </summary>
        Ipv4Default,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant4 value)
        {
            return value switch
            {
                ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant4.Ipv4Default => "ipv4_default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant4? ToEnum(string value)
        {
            return value switch
            {
                "ipv4_default" => ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant4.Ipv4Default,
                _ => null,
            };
        }
    }
}