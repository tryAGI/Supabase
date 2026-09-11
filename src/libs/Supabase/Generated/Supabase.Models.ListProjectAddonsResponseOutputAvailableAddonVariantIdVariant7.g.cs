
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant7
    {
        /// <summary>
        ///
        /// </summary>
        LogDrainDefault,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant7 value)
        {
            return value switch
            {
                ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant7.LogDrainDefault => "log_drain_default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant7? ToEnum(string value)
        {
            return value switch
            {
                "log_drain_default" => ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant7.LogDrainDefault,
                _ => null,
            };
        }
    }
}