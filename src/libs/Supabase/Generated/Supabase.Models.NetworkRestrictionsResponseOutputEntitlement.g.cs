
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum NetworkRestrictionsResponseOutputEntitlement
    {
        /// <summary>
        ///
        /// </summary>
        Allowed,
        /// <summary>
        ///
        /// </summary>
        Disallowed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NetworkRestrictionsResponseOutputEntitlementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NetworkRestrictionsResponseOutputEntitlement value)
        {
            return value switch
            {
                NetworkRestrictionsResponseOutputEntitlement.Allowed => "allowed",
                NetworkRestrictionsResponseOutputEntitlement.Disallowed => "disallowed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NetworkRestrictionsResponseOutputEntitlement? ToEnum(string value)
        {
            return value switch
            {
                "allowed" => NetworkRestrictionsResponseOutputEntitlement.Allowed,
                "disallowed" => NetworkRestrictionsResponseOutputEntitlement.Disallowed,
                _ => null,
            };
        }
    }
}