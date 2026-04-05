
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSigningKeyBodyPrivateJwkVariant4KeyOp
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
    public static class CreateSigningKeyBodyPrivateJwkVariant4KeyOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSigningKeyBodyPrivateJwkVariant4KeyOp value)
        {
            return value switch
            {
                CreateSigningKeyBodyPrivateJwkVariant4KeyOp.Sign => "sign",
                CreateSigningKeyBodyPrivateJwkVariant4KeyOp.Verify => "verify",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSigningKeyBodyPrivateJwkVariant4KeyOp? ToEnum(string value)
        {
            return value switch
            {
                "sign" => CreateSigningKeyBodyPrivateJwkVariant4KeyOp.Sign,
                "verify" => CreateSigningKeyBodyPrivateJwkVariant4KeyOp.Verify,
                _ => null,
            };
        }
    }
}