
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1RemoveProjectAddonAddonVariantVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        Ipv4Default,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1RemoveProjectAddonAddonVariantVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1RemoveProjectAddonAddonVariantVariant4 value)
        {
            return value switch
            {
                V1RemoveProjectAddonAddonVariantVariant4.Ipv4Default => "ipv4_default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1RemoveProjectAddonAddonVariantVariant4? ToEnum(string value)
        {
            return value switch
            {
                "ipv4_default" => V1RemoveProjectAddonAddonVariantVariant4.Ipv4Default,
                _ => null,
            };
        }
    }
}