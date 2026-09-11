
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum V1ListEntitlementsResponseOutputEntitlementType
    {
        /// <summary>
        ///
        /// </summary>
        Boolean,
        /// <summary>
        ///
        /// </summary>
        Numeric,
        /// <summary>
        ///
        /// </summary>
        Set,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1ListEntitlementsResponseOutputEntitlementTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ListEntitlementsResponseOutputEntitlementType value)
        {
            return value switch
            {
                V1ListEntitlementsResponseOutputEntitlementType.Boolean => "boolean",
                V1ListEntitlementsResponseOutputEntitlementType.Numeric => "numeric",
                V1ListEntitlementsResponseOutputEntitlementType.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ListEntitlementsResponseOutputEntitlementType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => V1ListEntitlementsResponseOutputEntitlementType.Boolean,
                "numeric" => V1ListEntitlementsResponseOutputEntitlementType.Numeric,
                "set" => V1ListEntitlementsResponseOutputEntitlementType.Set,
                _ => null,
            };
        }
    }
}