
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum DiskResponseOutputAttributesVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Io2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DiskResponseOutputAttributesVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DiskResponseOutputAttributesVariant2Type value)
        {
            return value switch
            {
                DiskResponseOutputAttributesVariant2Type.Io2 => "io2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DiskResponseOutputAttributesVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "io2" => DiskResponseOutputAttributesVariant2Type.Io2,
                _ => null,
            };
        }
    }
}