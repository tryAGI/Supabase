
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: code
    /// </summary>
    public enum V1OauthAuthorizeProjectClaimResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Code,
        /// <summary>
        /// 
        /// </summary>
        IdTokenToken,
        /// <summary>
        /// 
        /// </summary>
        Token,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1OauthAuthorizeProjectClaimResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1OauthAuthorizeProjectClaimResponseType value)
        {
            return value switch
            {
                V1OauthAuthorizeProjectClaimResponseType.Code => "code",
                V1OauthAuthorizeProjectClaimResponseType.IdTokenToken => "id_token token",
                V1OauthAuthorizeProjectClaimResponseType.Token => "token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1OauthAuthorizeProjectClaimResponseType? ToEnum(string value)
        {
            return value switch
            {
                "code" => V1OauthAuthorizeProjectClaimResponseType.Code,
                "id_token token" => V1OauthAuthorizeProjectClaimResponseType.IdTokenToken,
                "token" => V1OauthAuthorizeProjectClaimResponseType.Token,
                _ => null,
            };
        }
    }
}