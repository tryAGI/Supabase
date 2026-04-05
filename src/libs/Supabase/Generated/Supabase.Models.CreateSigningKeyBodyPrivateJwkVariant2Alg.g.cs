
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSigningKeyBodyPrivateJwkVariant2Alg
    {
        /// <summary>
        /// 
        /// </summary>
        Es256,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSigningKeyBodyPrivateJwkVariant2AlgExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSigningKeyBodyPrivateJwkVariant2Alg value)
        {
            return value switch
            {
                CreateSigningKeyBodyPrivateJwkVariant2Alg.Es256 => "ES256",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSigningKeyBodyPrivateJwkVariant2Alg? ToEnum(string value)
        {
            return value switch
            {
                "ES256" => CreateSigningKeyBodyPrivateJwkVariant2Alg.Es256,
                _ => null,
            };
        }
    }
}