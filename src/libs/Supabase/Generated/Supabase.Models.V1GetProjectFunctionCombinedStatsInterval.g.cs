
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: 1hr
    /// </summary>
    public enum V1GetProjectFunctionCombinedStatsInterval
    {
        /// <summary>
        /// 
        /// </summary>
        x15min,
        /// <summary>
        /// 
        /// </summary>
        x1day,
        /// <summary>
        /// 
        /// </summary>
        x1hr,
        /// <summary>
        /// 
        /// </summary>
        x3hr,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1GetProjectFunctionCombinedStatsIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1GetProjectFunctionCombinedStatsInterval value)
        {
            return value switch
            {
                V1GetProjectFunctionCombinedStatsInterval.x15min => "15min",
                V1GetProjectFunctionCombinedStatsInterval.x1day => "1day",
                V1GetProjectFunctionCombinedStatsInterval.x1hr => "1hr",
                V1GetProjectFunctionCombinedStatsInterval.x3hr => "3hr",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1GetProjectFunctionCombinedStatsInterval? ToEnum(string value)
        {
            return value switch
            {
                "15min" => V1GetProjectFunctionCombinedStatsInterval.x15min,
                "1day" => V1GetProjectFunctionCombinedStatsInterval.x1day,
                "1hr" => V1GetProjectFunctionCombinedStatsInterval.x1hr,
                "3hr" => V1GetProjectFunctionCombinedStatsInterval.x3hr,
                _ => null,
            };
        }
    }
}