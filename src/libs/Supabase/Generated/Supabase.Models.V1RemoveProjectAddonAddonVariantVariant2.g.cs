
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1RemoveProjectAddonAddonVariantVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        CdDefault,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1RemoveProjectAddonAddonVariantVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1RemoveProjectAddonAddonVariantVariant2 value)
        {
            return value switch
            {
                V1RemoveProjectAddonAddonVariantVariant2.CdDefault => "cd_default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1RemoveProjectAddonAddonVariantVariant2? ToEnum(string value)
        {
            return value switch
            {
                "cd_default" => V1RemoveProjectAddonAddonVariantVariant2.CdDefault,
                _ => null,
            };
        }
    }
}