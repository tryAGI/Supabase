
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ApiKeyResponseOutputType
    {
        /// <summary>
        ///
        /// </summary>
        Legacy,
        /// <summary>
        ///
        /// </summary>
        Publishable,
        /// <summary>
        ///
        /// </summary>
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiKeyResponseOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiKeyResponseOutputType value)
        {
            return value switch
            {
                ApiKeyResponseOutputType.Legacy => "legacy",
                ApiKeyResponseOutputType.Publishable => "publishable",
                ApiKeyResponseOutputType.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiKeyResponseOutputType? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => ApiKeyResponseOutputType.Legacy,
                "publishable" => ApiKeyResponseOutputType.Publishable,
                "secret" => ApiKeyResponseOutputType.Secret,
                _ => null,
            };
        }
    }
}