
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProviderResponseSamlNameIdFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Urn_oasis_names_tc_SAML_11_nameidFormat_emailAddress,
        /// <summary>
        /// 
        /// </summary>
        Urn_oasis_names_tc_SAML_11_nameidFormat_unspecified,
        /// <summary>
        /// 
        /// </summary>
        Urn_oasis_names_tc_SAML_20_nameidFormat_persistent,
        /// <summary>
        /// 
        /// </summary>
        Urn_oasis_names_tc_SAML_20_nameidFormat_transient,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProviderResponseSamlNameIdFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProviderResponseSamlNameIdFormat value)
        {
            return value switch
            {
                CreateProviderResponseSamlNameIdFormat.Urn_oasis_names_tc_SAML_11_nameidFormat_emailAddress => "urn:oasis:names:tc:SAML:1.1:nameid-format:emailAddress",
                CreateProviderResponseSamlNameIdFormat.Urn_oasis_names_tc_SAML_11_nameidFormat_unspecified => "urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified",
                CreateProviderResponseSamlNameIdFormat.Urn_oasis_names_tc_SAML_20_nameidFormat_persistent => "urn:oasis:names:tc:SAML:2.0:nameid-format:persistent",
                CreateProviderResponseSamlNameIdFormat.Urn_oasis_names_tc_SAML_20_nameidFormat_transient => "urn:oasis:names:tc:SAML:2.0:nameid-format:transient",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProviderResponseSamlNameIdFormat? ToEnum(string value)
        {
            return value switch
            {
                "urn:oasis:names:tc:SAML:1.1:nameid-format:emailAddress" => CreateProviderResponseSamlNameIdFormat.Urn_oasis_names_tc_SAML_11_nameidFormat_emailAddress,
                "urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified" => CreateProviderResponseSamlNameIdFormat.Urn_oasis_names_tc_SAML_11_nameidFormat_unspecified,
                "urn:oasis:names:tc:SAML:2.0:nameid-format:persistent" => CreateProviderResponseSamlNameIdFormat.Urn_oasis_names_tc_SAML_20_nameidFormat_persistent,
                "urn:oasis:names:tc:SAML:2.0:nameid-format:transient" => CreateProviderResponseSamlNameIdFormat.Urn_oasis_names_tc_SAML_20_nameidFormat_transient,
                _ => null,
            };
        }
    }
}