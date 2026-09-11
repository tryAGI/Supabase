
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum V1ListEntitlementsResponseOutputEntitlementFeatureType
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
    public static class V1ListEntitlementsResponseOutputEntitlementFeatureTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ListEntitlementsResponseOutputEntitlementFeatureType value)
        {
            return value switch
            {
                V1ListEntitlementsResponseOutputEntitlementFeatureType.Boolean => "boolean",
                V1ListEntitlementsResponseOutputEntitlementFeatureType.Numeric => "numeric",
                V1ListEntitlementsResponseOutputEntitlementFeatureType.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ListEntitlementsResponseOutputEntitlementFeatureType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => V1ListEntitlementsResponseOutputEntitlementFeatureType.Boolean,
                "numeric" => V1ListEntitlementsResponseOutputEntitlementFeatureType.Numeric,
                "set" => V1ListEntitlementsResponseOutputEntitlementFeatureType.Set,
                _ => null,
            };
        }
    }
}