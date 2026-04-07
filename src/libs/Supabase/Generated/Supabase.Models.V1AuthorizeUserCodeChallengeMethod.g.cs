
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: S256
    /// </summary>
    public enum V1AuthorizeUserCodeChallengeMethod
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
    public static class V1AuthorizeUserCodeChallengeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1AuthorizeUserCodeChallengeMethod value)
        {
            return value switch
            {
                V1AuthorizeUserCodeChallengeMethod.S256 => "S256",
                V1AuthorizeUserCodeChallengeMethod.Plain => "plain",
                V1AuthorizeUserCodeChallengeMethod.Sha256 => "sha256",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1AuthorizeUserCodeChallengeMethod? ToEnum(string value)
        {
            return value switch
            {
                "S256" => V1AuthorizeUserCodeChallengeMethod.S256,
                "plain" => V1AuthorizeUserCodeChallengeMethod.Plain,
                "sha256" => V1AuthorizeUserCodeChallengeMethod.Sha256,
                _ => null,
            };
        }
    }
}