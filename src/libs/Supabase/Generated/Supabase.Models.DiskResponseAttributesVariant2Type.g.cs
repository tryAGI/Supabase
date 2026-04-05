
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum DiskResponseAttributesVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Io2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DiskResponseAttributesVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DiskResponseAttributesVariant2Type value)
        {
            return value switch
            {
                DiskResponseAttributesVariant2Type.Io2 => "io2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DiskResponseAttributesVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "io2" => DiskResponseAttributesVariant2Type.Io2,
                _ => null,
            };
        }
    }
}