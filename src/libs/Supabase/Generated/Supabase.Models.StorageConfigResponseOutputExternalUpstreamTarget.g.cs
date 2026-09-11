
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum StorageConfigResponseOutputExternalUpstreamTarget
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
    public static class StorageConfigResponseOutputExternalUpstreamTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StorageConfigResponseOutputExternalUpstreamTarget value)
        {
            return value switch
            {
                StorageConfigResponseOutputExternalUpstreamTarget.Canary => "canary",
                StorageConfigResponseOutputExternalUpstreamTarget.Main => "main",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StorageConfigResponseOutputExternalUpstreamTarget? ToEnum(string value)
        {
            return value switch
            {
                "canary" => StorageConfigResponseOutputExternalUpstreamTarget.Canary,
                "main" => StorageConfigResponseOutputExternalUpstreamTarget.Main,
                _ => null,
            };
        }
    }
}