
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSigningKeyBodyPrivateJwkVariant1KeyOp
    {
        /// <summary>
        /// 
        /// </summary>
        Sign,
        /// <summary>
        /// 
        /// </summary>
        Verify,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSigningKeyBodyPrivateJwkVariant1KeyOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSigningKeyBodyPrivateJwkVariant1KeyOp value)
        {
            return value switch
            {
                CreateSigningKeyBodyPrivateJwkVariant1KeyOp.Sign => "sign",
                CreateSigningKeyBodyPrivateJwkVariant1KeyOp.Verify => "verify",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSigningKeyBodyPrivateJwkVariant1KeyOp? ToEnum(string value)
        {
            return value switch
            {
                "sign" => CreateSigningKeyBodyPrivateJwkVariant1KeyOp.Sign,
                "verify" => CreateSigningKeyBodyPrivateJwkVariant1KeyOp.Verify,
                _ => null,
            };
        }
    }
}