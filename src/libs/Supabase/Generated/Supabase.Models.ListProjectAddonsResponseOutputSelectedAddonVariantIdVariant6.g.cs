
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant6
    {
        /// <summary>
        ///
        /// </summary>
        AuthMfaWebAuthnDefault,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant6 value)
        {
            return value switch
            {
                ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant6.AuthMfaWebAuthnDefault => "auth_mfa_web_authn_default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant6? ToEnum(string value)
        {
            return value switch
            {
                "auth_mfa_web_authn_default" => ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant6.AuthMfaWebAuthnDefault,
                _ => null,
            };
        }
    }
}