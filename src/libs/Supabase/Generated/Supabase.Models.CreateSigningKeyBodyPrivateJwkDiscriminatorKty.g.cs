
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSigningKeyBodyPrivateJwkDiscriminatorKty
    {
        /// <summary>
        /// 
        /// </summary>
        Ec,
        /// <summary>
        /// 
        /// </summary>
        Okp,
        /// <summary>
        /// 
        /// </summary>
        Rsa,
        /// <summary>
        /// 
        /// </summary>
        Oct,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSigningKeyBodyPrivateJwkDiscriminatorKtyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSigningKeyBodyPrivateJwkDiscriminatorKty value)
        {
            return value switch
            {
                CreateSigningKeyBodyPrivateJwkDiscriminatorKty.Ec => "EC",
                CreateSigningKeyBodyPrivateJwkDiscriminatorKty.Okp => "OKP",
                CreateSigningKeyBodyPrivateJwkDiscriminatorKty.Rsa => "RSA",
                CreateSigningKeyBodyPrivateJwkDiscriminatorKty.Oct => "oct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSigningKeyBodyPrivateJwkDiscriminatorKty? ToEnum(string value)
        {
            return value switch
            {
                "EC" => CreateSigningKeyBodyPrivateJwkDiscriminatorKty.Ec,
                "OKP" => CreateSigningKeyBodyPrivateJwkDiscriminatorKty.Okp,
                "RSA" => CreateSigningKeyBodyPrivateJwkDiscriminatorKty.Rsa,
                "oct" => CreateSigningKeyBodyPrivateJwkDiscriminatorKty.Oct,
                _ => null,
            };
        }
    }
}