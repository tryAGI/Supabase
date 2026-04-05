
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSigningKeyBodyPrivateJwkVariant3KeyOp
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
    public static class CreateSigningKeyBodyPrivateJwkVariant3KeyOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSigningKeyBodyPrivateJwkVariant3KeyOp value)
        {
            return value switch
            {
                CreateSigningKeyBodyPrivateJwkVariant3KeyOp.Sign => "sign",
                CreateSigningKeyBodyPrivateJwkVariant3KeyOp.Verify => "verify",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSigningKeyBodyPrivateJwkVariant3KeyOp? ToEnum(string value)
        {
            return value switch
            {
                "sign" => CreateSigningKeyBodyPrivateJwkVariant3KeyOp.Sign,
                "verify" => CreateSigningKeyBodyPrivateJwkVariant3KeyOp.Verify,
                _ => null,
            };
        }
    }
}