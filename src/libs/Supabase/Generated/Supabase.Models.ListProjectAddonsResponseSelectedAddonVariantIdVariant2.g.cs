
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListProjectAddonsResponseSelectedAddonVariantIdVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        CdDefault,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectAddonsResponseSelectedAddonVariantIdVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectAddonsResponseSelectedAddonVariantIdVariant2 value)
        {
            return value switch
            {
                ListProjectAddonsResponseSelectedAddonVariantIdVariant2.CdDefault => "cd_default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectAddonsResponseSelectedAddonVariantIdVariant2? ToEnum(string value)
        {
            return value switch
            {
                "cd_default" => ListProjectAddonsResponseSelectedAddonVariantIdVariant2.CdDefault,
                _ => null,
            };
        }
    }
}