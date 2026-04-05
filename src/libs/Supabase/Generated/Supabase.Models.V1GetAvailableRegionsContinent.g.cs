
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: NA
    /// </summary>
    public enum V1GetAvailableRegionsContinent
    {
        /// <summary>
        /// NA (North America), SA (South America), EU (Europe), AF (Africa), AS (Asia), OC (Oceania), AN (Antarctica)
        /// </summary>
        Af,
        /// <summary>
        /// NA (North America), SA (South America), EU (Europe), AF (Africa), AS (Asia), OC (Oceania), AN (Antarctica)
        /// </summary>
        An,
        /// <summary>
        /// NA (North America), SA (South America), EU (Europe), AF (Africa), AS (Asia), OC (Oceania), AN (Antarctica)
        /// </summary>
        As,
        /// <summary>
        /// NA (North America), SA (South America), EU (Europe), AF (Africa), AS (Asia), OC (Oceania), AN (Antarctica)
        /// </summary>
        Eu,
        /// <summary>
        /// NA (North America), SA (South America), EU (Europe), AF (Africa), AS (Asia), OC (Oceania), AN (Antarctica)
        /// </summary>
        Na,
        /// <summary>
        /// NA (North America), SA (South America), EU (Europe), AF (Africa), AS (Asia), OC (Oceania), AN (Antarctica)
        /// </summary>
        Oc,
        /// <summary>
        /// NA (North America), SA (South America), EU (Europe), AF (Africa), AS (Asia), OC (Oceania), AN (Antarctica)
        /// </summary>
        Sa,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1GetAvailableRegionsContinentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1GetAvailableRegionsContinent value)
        {
            return value switch
            {
                V1GetAvailableRegionsContinent.Af => "AF",
                V1GetAvailableRegionsContinent.An => "AN",
                V1GetAvailableRegionsContinent.As => "AS",
                V1GetAvailableRegionsContinent.Eu => "EU",
                V1GetAvailableRegionsContinent.Na => "NA",
                V1GetAvailableRegionsContinent.Oc => "OC",
                V1GetAvailableRegionsContinent.Sa => "SA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1GetAvailableRegionsContinent? ToEnum(string value)
        {
            return value switch
            {
                "AF" => V1GetAvailableRegionsContinent.Af,
                "AN" => V1GetAvailableRegionsContinent.An,
                "AS" => V1GetAvailableRegionsContinent.As,
                "EU" => V1GetAvailableRegionsContinent.Eu,
                "NA" => V1GetAvailableRegionsContinent.Na,
                "OC" => V1GetAvailableRegionsContinent.Oc,
                "SA" => V1GetAvailableRegionsContinent.Sa,
                _ => null,
            };
        }
    }
}