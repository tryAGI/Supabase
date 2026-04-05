
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum OAuthTokenBodyGrantType
    {
        /// <summary>
        /// 
        /// </summary>
        AuthorizationCode,
        /// <summary>
        /// 
        /// </summary>
        RefreshToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OAuthTokenBodyGrantTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OAuthTokenBodyGrantType value)
        {
            return value switch
            {
                OAuthTokenBodyGrantType.AuthorizationCode => "authorization_code",
                OAuthTokenBodyGrantType.RefreshToken => "refresh_token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OAuthTokenBodyGrantType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_code" => OAuthTokenBodyGrantType.AuthorizationCode,
                "refresh_token" => OAuthTokenBodyGrantType.RefreshToken,
                _ => null,
            };
        }
    }
}