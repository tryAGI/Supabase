
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1ListEntitlementsResponseEntitlementFeatureType
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
    public static class V1ListEntitlementsResponseEntitlementFeatureTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ListEntitlementsResponseEntitlementFeatureType value)
        {
            return value switch
            {
                V1ListEntitlementsResponseEntitlementFeatureType.Boolean => "boolean",
                V1ListEntitlementsResponseEntitlementFeatureType.Numeric => "numeric",
                V1ListEntitlementsResponseEntitlementFeatureType.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ListEntitlementsResponseEntitlementFeatureType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => V1ListEntitlementsResponseEntitlementFeatureType.Boolean,
                "numeric" => V1ListEntitlementsResponseEntitlementFeatureType.Numeric,
                "set" => V1ListEntitlementsResponseEntitlementFeatureType.Set,
                _ => null,
            };
        }
    }
}