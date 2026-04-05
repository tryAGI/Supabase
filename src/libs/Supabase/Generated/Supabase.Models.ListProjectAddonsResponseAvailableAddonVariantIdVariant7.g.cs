
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListProjectAddonsResponseAvailableAddonVariantIdVariant7
    {
        /// <summary>
        /// 
        /// </summary>
        LogDrainDefault,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectAddonsResponseAvailableAddonVariantIdVariant7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectAddonsResponseAvailableAddonVariantIdVariant7 value)
        {
            return value switch
            {
                ListProjectAddonsResponseAvailableAddonVariantIdVariant7.LogDrainDefault => "log_drain_default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectAddonsResponseAvailableAddonVariantIdVariant7? ToEnum(string value)
        {
            return value switch
            {
                "log_drain_default" => ListProjectAddonsResponseAvailableAddonVariantIdVariant7.LogDrainDefault,
                _ => null,
            };
        }
    }
}