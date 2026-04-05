
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiKeyResponseType
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
    public static class ApiKeyResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiKeyResponseType value)
        {
            return value switch
            {
                ApiKeyResponseType.Legacy => "legacy",
                ApiKeyResponseType.Publishable => "publishable",
                ApiKeyResponseType.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiKeyResponseType? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => ApiKeyResponseType.Legacy,
                "publishable" => ApiKeyResponseType.Publishable,
                "secret" => ApiKeyResponseType.Secret,
                _ => null,
            };
        }
    }
}