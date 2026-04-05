
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSigningKeyBodyPrivateJwkVariant2KeyOp
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
    public static class CreateSigningKeyBodyPrivateJwkVariant2KeyOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSigningKeyBodyPrivateJwkVariant2KeyOp value)
        {
            return value switch
            {
                CreateSigningKeyBodyPrivateJwkVariant2KeyOp.Sign => "sign",
                CreateSigningKeyBodyPrivateJwkVariant2KeyOp.Verify => "verify",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSigningKeyBodyPrivateJwkVariant2KeyOp? ToEnum(string value)
        {
            return value switch
            {
                "sign" => CreateSigningKeyBodyPrivateJwkVariant2KeyOp.Sign,
                "verify" => CreateSigningKeyBodyPrivateJwkVariant2KeyOp.Verify,
                _ => null,
            };
        }
    }
}