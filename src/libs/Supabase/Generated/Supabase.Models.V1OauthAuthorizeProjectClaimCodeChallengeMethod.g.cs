
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: S256
    /// </summary>
    public enum V1OauthAuthorizeProjectClaimCodeChallengeMethod
    {
        /// <summary>
        /// 
        /// </summary>
        S256,
        /// <summary>
        /// 
        /// </summary>
        Plain,
        /// <summary>
        /// 
        /// </summary>
        Sha256,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1OauthAuthorizeProjectClaimCodeChallengeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1OauthAuthorizeProjectClaimCodeChallengeMethod value)
        {
            return value switch
            {
                V1OauthAuthorizeProjectClaimCodeChallengeMethod.S256 => "S256",
                V1OauthAuthorizeProjectClaimCodeChallengeMethod.Plain => "plain",
                V1OauthAuthorizeProjectClaimCodeChallengeMethod.Sha256 => "sha256",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1OauthAuthorizeProjectClaimCodeChallengeMethod? ToEnum(string value)
        {
            return value switch
            {
                "S256" => V1OauthAuthorizeProjectClaimCodeChallengeMethod.S256,
                "plain" => V1OauthAuthorizeProjectClaimCodeChallengeMethod.Plain,
                "sha256" => V1OauthAuthorizeProjectClaimCodeChallengeMethod.Sha256,
                _ => null,
            };
        }
    }
}