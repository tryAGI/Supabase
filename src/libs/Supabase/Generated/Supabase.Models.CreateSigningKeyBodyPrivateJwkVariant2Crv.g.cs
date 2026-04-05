
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSigningKeyBodyPrivateJwkVariant2Crv
    {
        /// <summary>
        /// 
        /// </summary>
        P256,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSigningKeyBodyPrivateJwkVariant2CrvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSigningKeyBodyPrivateJwkVariant2Crv value)
        {
            return value switch
            {
                CreateSigningKeyBodyPrivateJwkVariant2Crv.P256 => "P-256",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSigningKeyBodyPrivateJwkVariant2Crv? ToEnum(string value)
        {
            return value switch
            {
                "P-256" => CreateSigningKeyBodyPrivateJwkVariant2Crv.P256,
                _ => null,
            };
        }
    }
}