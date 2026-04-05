
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum OAuthTokenResponseTokenType
    {
        /// <summary>
        /// 
        /// </summary>
        Bearer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OAuthTokenResponseTokenTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OAuthTokenResponseTokenType value)
        {
            return value switch
            {
                OAuthTokenResponseTokenType.Bearer => "Bearer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OAuthTokenResponseTokenType? ToEnum(string value)
        {
            return value switch
            {
                "Bearer" => OAuthTokenResponseTokenType.Bearer,
                _ => null,
            };
        }
    }
}