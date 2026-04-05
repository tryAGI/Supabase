
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1RemoveProjectAddonAddonVariantVariant3
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
    public static class V1RemoveProjectAddonAddonVariantVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1RemoveProjectAddonAddonVariantVariant3 value)
        {
            return value switch
            {
                V1RemoveProjectAddonAddonVariantVariant3.Pitr14 => "pitr_14",
                V1RemoveProjectAddonAddonVariantVariant3.Pitr28 => "pitr_28",
                V1RemoveProjectAddonAddonVariantVariant3.Pitr7 => "pitr_7",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1RemoveProjectAddonAddonVariantVariant3? ToEnum(string value)
        {
            return value switch
            {
                "pitr_14" => V1RemoveProjectAddonAddonVariantVariant3.Pitr14,
                "pitr_28" => V1RemoveProjectAddonAddonVariantVariant3.Pitr28,
                "pitr_7" => V1RemoveProjectAddonAddonVariantVariant3.Pitr7,
                _ => null,
            };
        }
    }
}