
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant6
    {
        /// <summary>
        ///
        /// </summary>
        AuthMfaWebAuthnDefault,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant6 value)
        {
            return value switch
            {
                ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant6.AuthMfaWebAuthnDefault => "auth_mfa_web_authn_default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant6? ToEnum(string value)
        {
            return value switch
            {
                "auth_mfa_web_authn_default" => ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant6.AuthMfaWebAuthnDefault,
                _ => null,
            };
        }
    }
}