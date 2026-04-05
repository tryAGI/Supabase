
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListProjectAddonsResponseAvailableAddonVariantIdVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        CdDefault,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectAddonsResponseAvailableAddonVariantIdVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectAddonsResponseAvailableAddonVariantIdVariant2 value)
        {
            return value switch
            {
                ListProjectAddonsResponseAvailableAddonVariantIdVariant2.CdDefault => "cd_default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectAddonsResponseAvailableAddonVariantIdVariant2? ToEnum(string value)
        {
            return value switch
            {
                "cd_default" => ListProjectAddonsResponseAvailableAddonVariantIdVariant2.CdDefault,
                _ => null,
            };
        }
    }
}