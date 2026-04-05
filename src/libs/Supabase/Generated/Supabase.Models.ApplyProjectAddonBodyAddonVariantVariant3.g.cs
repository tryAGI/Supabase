
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApplyProjectAddonBodyAddonVariantVariant3
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
    public static class ApplyProjectAddonBodyAddonVariantVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyProjectAddonBodyAddonVariantVariant3 value)
        {
            return value switch
            {
                ApplyProjectAddonBodyAddonVariantVariant3.Pitr14 => "pitr_14",
                ApplyProjectAddonBodyAddonVariantVariant3.Pitr28 => "pitr_28",
                ApplyProjectAddonBodyAddonVariantVariant3.Pitr7 => "pitr_7",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyProjectAddonBodyAddonVariantVariant3? ToEnum(string value)
        {
            return value switch
            {
                "pitr_14" => ApplyProjectAddonBodyAddonVariantVariant3.Pitr14,
                "pitr_28" => ApplyProjectAddonBodyAddonVariantVariant3.Pitr28,
                "pitr_7" => ApplyProjectAddonBodyAddonVariantVariant3.Pitr7,
                _ => null,
            };
        }
    }
}