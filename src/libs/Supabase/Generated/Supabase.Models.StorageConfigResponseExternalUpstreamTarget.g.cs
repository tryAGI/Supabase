
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum StorageConfigResponseExternalUpstreamTarget
    {
        /// <summary>
        /// 
        /// </summary>
        Canary,
        /// <summary>
        /// 
        /// </summary>
        Main,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StorageConfigResponseExternalUpstreamTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StorageConfigResponseExternalUpstreamTarget value)
        {
            return value switch
            {
                StorageConfigResponseExternalUpstreamTarget.Canary => "canary",
                StorageConfigResponseExternalUpstreamTarget.Main => "main",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StorageConfigResponseExternalUpstreamTarget? ToEnum(string value)
        {
            return value switch
            {
                "canary" => StorageConfigResponseExternalUpstreamTarget.Canary,
                "main" => StorageConfigResponseExternalUpstreamTarget.Main,
                _ => null,
            };
        }
    }
}