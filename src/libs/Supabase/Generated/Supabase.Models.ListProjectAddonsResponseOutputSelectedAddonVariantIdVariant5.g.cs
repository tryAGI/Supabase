
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant5
    {
        /// <summary>
        ///
        /// </summary>
        AuthMfaPhoneDefault,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant5 value)
        {
            return value switch
            {
                ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant5.AuthMfaPhoneDefault => "auth_mfa_phone_default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant5? ToEnum(string value)
        {
            return value switch
            {
                "auth_mfa_phone_default" => ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant5.AuthMfaPhoneDefault,
                _ => null,
            };
        }
    }
}