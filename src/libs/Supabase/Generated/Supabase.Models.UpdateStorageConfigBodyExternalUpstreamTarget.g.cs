
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateStorageConfigBodyExternalUpstreamTarget
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
    public static class UpdateStorageConfigBodyExternalUpstreamTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateStorageConfigBodyExternalUpstreamTarget value)
        {
            return value switch
            {
                UpdateStorageConfigBodyExternalUpstreamTarget.Canary => "canary",
                UpdateStorageConfigBodyExternalUpstreamTarget.Main => "main",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateStorageConfigBodyExternalUpstreamTarget? ToEnum(string value)
        {
            return value switch
            {
                "canary" => UpdateStorageConfigBodyExternalUpstreamTarget.Canary,
                "main" => UpdateStorageConfigBodyExternalUpstreamTarget.Main,
                _ => null,
            };
        }
    }
}