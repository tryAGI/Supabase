
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant7
    {
        /// <summary>
        ///
        /// </summary>
        LogDrainDefault,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant7 value)
        {
            return value switch
            {
                ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant7.LogDrainDefault => "log_drain_default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant7? ToEnum(string value)
        {
            return value switch
            {
                "log_drain_default" => ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant7.LogDrainDefault,
                _ => null,
            };
        }
    }
}