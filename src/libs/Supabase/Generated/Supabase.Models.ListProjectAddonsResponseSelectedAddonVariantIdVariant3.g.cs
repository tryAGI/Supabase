
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListProjectAddonsResponseSelectedAddonVariantIdVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        Pitr14,
        /// <summary>
        /// 
        /// </summary>
        Pitr28,
        /// <summary>
        /// 
        /// </summary>
        Pitr7,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectAddonsResponseSelectedAddonVariantIdVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectAddonsResponseSelectedAddonVariantIdVariant3 value)
        {
            return value switch
            {
                ListProjectAddonsResponseSelectedAddonVariantIdVariant3.Pitr14 => "pitr_14",
                ListProjectAddonsResponseSelectedAddonVariantIdVariant3.Pitr28 => "pitr_28",
                ListProjectAddonsResponseSelectedAddonVariantIdVariant3.Pitr7 => "pitr_7",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectAddonsResponseSelectedAddonVariantIdVariant3? ToEnum(string value)
        {
            return value switch
            {
                "pitr_14" => ListProjectAddonsResponseSelectedAddonVariantIdVariant3.Pitr14,
                "pitr_28" => ListProjectAddonsResponseSelectedAddonVariantIdVariant3.Pitr28,
                "pitr_7" => ListProjectAddonsResponseSelectedAddonVariantIdVariant3.Pitr7,
                _ => null,
            };
        }
    }
}