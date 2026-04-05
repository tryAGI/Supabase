
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSigningKeyBodyPrivateJwkVariant1Alg
    {
        /// <summary>
        /// 
        /// </summary>
        Rs256,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSigningKeyBodyPrivateJwkVariant1AlgExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSigningKeyBodyPrivateJwkVariant1Alg value)
        {
            return value switch
            {
                CreateSigningKeyBodyPrivateJwkVariant1Alg.Rs256 => "RS256",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSigningKeyBodyPrivateJwkVariant1Alg? ToEnum(string value)
        {
            return value switch
            {
                "RS256" => CreateSigningKeyBodyPrivateJwkVariant1Alg.Rs256,
                _ => null,
            };
        }
    }
}