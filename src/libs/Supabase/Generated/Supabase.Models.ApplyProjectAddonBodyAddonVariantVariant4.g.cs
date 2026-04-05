
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApplyProjectAddonBodyAddonVariantVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        Ipv4Default,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyProjectAddonBodyAddonVariantVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyProjectAddonBodyAddonVariantVariant4 value)
        {
            return value switch
            {
                ApplyProjectAddonBodyAddonVariantVariant4.Ipv4Default => "ipv4_default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyProjectAddonBodyAddonVariantVariant4? ToEnum(string value)
        {
            return value switch
            {
                "ipv4_default" => ApplyProjectAddonBodyAddonVariantVariant4.Ipv4Default,
                _ => null,
            };
        }
    }
}