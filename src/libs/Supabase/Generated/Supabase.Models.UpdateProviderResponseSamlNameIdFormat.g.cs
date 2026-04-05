
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProviderResponseSamlNameIdFormat
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
    public static class UpdateProviderResponseSamlNameIdFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProviderResponseSamlNameIdFormat value)
        {
            return value switch
            {
                UpdateProviderResponseSamlNameIdFormat.Urn_oasis_names_tc_SAML_11_nameidFormat_emailAddress => "urn:oasis:names:tc:SAML:1.1:nameid-format:emailAddress",
                UpdateProviderResponseSamlNameIdFormat.Urn_oasis_names_tc_SAML_11_nameidFormat_unspecified => "urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified",
                UpdateProviderResponseSamlNameIdFormat.Urn_oasis_names_tc_SAML_20_nameidFormat_persistent => "urn:oasis:names:tc:SAML:2.0:nameid-format:persistent",
                UpdateProviderResponseSamlNameIdFormat.Urn_oasis_names_tc_SAML_20_nameidFormat_transient => "urn:oasis:names:tc:SAML:2.0:nameid-format:transient",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProviderResponseSamlNameIdFormat? ToEnum(string value)
        {
            return value switch
            {
                "urn:oasis:names:tc:SAML:1.1:nameid-format:emailAddress" => UpdateProviderResponseSamlNameIdFormat.Urn_oasis_names_tc_SAML_11_nameidFormat_emailAddress,
                "urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified" => UpdateProviderResponseSamlNameIdFormat.Urn_oasis_names_tc_SAML_11_nameidFormat_unspecified,
                "urn:oasis:names:tc:SAML:2.0:nameid-format:persistent" => UpdateProviderResponseSamlNameIdFormat.Urn_oasis_names_tc_SAML_20_nameidFormat_persistent,
                "urn:oasis:names:tc:SAML:2.0:nameid-format:transient" => UpdateProviderResponseSamlNameIdFormat.Urn_oasis_names_tc_SAML_20_nameidFormat_transient,
                _ => null,
            };
        }
    }
}