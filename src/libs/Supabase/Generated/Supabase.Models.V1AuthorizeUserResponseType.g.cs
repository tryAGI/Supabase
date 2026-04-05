
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1AuthorizeUserResponseType
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
    public static class V1AuthorizeUserResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1AuthorizeUserResponseType value)
        {
            return value switch
            {
                V1AuthorizeUserResponseType.Code => "code",
                V1AuthorizeUserResponseType.IdTokenToken => "id_token token",
                V1AuthorizeUserResponseType.Token => "token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1AuthorizeUserResponseType? ToEnum(string value)
        {
            return value switch
            {
                "code" => V1AuthorizeUserResponseType.Code,
                "id_token token" => V1AuthorizeUserResponseType.IdTokenToken,
                "token" => V1AuthorizeUserResponseType.Token,
                _ => null,
            };
        }
    }
}