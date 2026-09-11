
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant2
    {
        /// <summary>
        ///
        /// </summary>
        CdDefault,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant2 value)
        {
            return value switch
            {
                ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant2.CdDefault => "cd_default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant2? ToEnum(string value)
        {
            return value switch
            {
                "cd_default" => ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant2.CdDefault,
                _ => null,
            };
        }
    }
}