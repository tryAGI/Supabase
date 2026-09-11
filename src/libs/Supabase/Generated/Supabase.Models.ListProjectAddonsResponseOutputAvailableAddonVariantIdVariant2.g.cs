
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant2
    {
        /// <summary>
        ///
        /// </summary>
        CdDefault,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant2 value)
        {
            return value switch
            {
                ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant2.CdDefault => "cd_default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant2? ToEnum(string value)
        {
            return value switch
            {
                "cd_default" => ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant2.CdDefault,
                _ => null,
            };
        }
    }
}