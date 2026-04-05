
#nullable enable

namespace Supabase
{
    /// <summary>
    /// The Smart Region Group's code. The codes supported are not a stable API, and should be retrieved from the /available-regions endpoint.<br/>
    /// Example: apac
    /// </summary>
    public enum V1CreateProjectBodyRegionSelectionVariant2Code
    {
        /// <summary>
        /// 
        /// </summary>
        Americas,
        /// <summary>
        /// 
        /// </summary>
        Apac,
        /// <summary>
        /// 
        /// </summary>
        Emea,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1CreateProjectBodyRegionSelectionVariant2CodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1CreateProjectBodyRegionSelectionVariant2Code value)
        {
            return value switch
            {
                V1CreateProjectBodyRegionSelectionVariant2Code.Americas => "americas",
                V1CreateProjectBodyRegionSelectionVariant2Code.Apac => "apac",
                V1CreateProjectBodyRegionSelectionVariant2Code.Emea => "emea",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1CreateProjectBodyRegionSelectionVariant2Code? ToEnum(string value)
        {
            return value switch
            {
                "americas" => V1CreateProjectBodyRegionSelectionVariant2Code.Americas,
                "apac" => V1CreateProjectBodyRegionSelectionVariant2Code.Apac,
                "emea" => V1CreateProjectBodyRegionSelectionVariant2Code.Emea,
                _ => null,
            };
        }
    }
}