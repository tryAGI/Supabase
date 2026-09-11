
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum OAuthTokenResponseOutputTokenType
    {
        /// <summary>
        ///
        /// </summary>
        Bearer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OAuthTokenResponseOutputTokenTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OAuthTokenResponseOutputTokenType value)
        {
            return value switch
            {
                OAuthTokenResponseOutputTokenType.Bearer => "Bearer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OAuthTokenResponseOutputTokenType? ToEnum(string value)
        {
            return value switch
            {
                "Bearer" => OAuthTokenResponseOutputTokenType.Bearer,
                _ => null,
            };
        }
    }
}