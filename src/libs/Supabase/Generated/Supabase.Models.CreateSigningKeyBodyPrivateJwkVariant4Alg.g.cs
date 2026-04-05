
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSigningKeyBodyPrivateJwkVariant4Alg
    {
        /// <summary>
        /// 
        /// </summary>
        Hs256,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSigningKeyBodyPrivateJwkVariant4AlgExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSigningKeyBodyPrivateJwkVariant4Alg value)
        {
            return value switch
            {
                CreateSigningKeyBodyPrivateJwkVariant4Alg.Hs256 => "HS256",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSigningKeyBodyPrivateJwkVariant4Alg? ToEnum(string value)
        {
            return value switch
            {
                "HS256" => CreateSigningKeyBodyPrivateJwkVariant4Alg.Hs256,
                _ => null,
            };
        }
    }
}