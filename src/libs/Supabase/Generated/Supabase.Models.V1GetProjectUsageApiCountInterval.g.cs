
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1GetProjectUsageApiCountInterval
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
        x30min,
        /// <summary>
        /// 
        /// </summary>
        x3day,
        /// <summary>
        /// 
        /// </summary>
        x3hr,
        /// <summary>
        /// 
        /// </summary>
        x7day,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1GetProjectUsageApiCountIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1GetProjectUsageApiCountInterval value)
        {
            return value switch
            {
                V1GetProjectUsageApiCountInterval.x15min => "15min",
                V1GetProjectUsageApiCountInterval.x1day => "1day",
                V1GetProjectUsageApiCountInterval.x1hr => "1hr",
                V1GetProjectUsageApiCountInterval.x30min => "30min",
                V1GetProjectUsageApiCountInterval.x3day => "3day",
                V1GetProjectUsageApiCountInterval.x3hr => "3hr",
                V1GetProjectUsageApiCountInterval.x7day => "7day",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1GetProjectUsageApiCountInterval? ToEnum(string value)
        {
            return value switch
            {
                "15min" => V1GetProjectUsageApiCountInterval.x15min,
                "1day" => V1GetProjectUsageApiCountInterval.x1day,
                "1hr" => V1GetProjectUsageApiCountInterval.x1hr,
                "30min" => V1GetProjectUsageApiCountInterval.x30min,
                "3day" => V1GetProjectUsageApiCountInterval.x3day,
                "3hr" => V1GetProjectUsageApiCountInterval.x3hr,
                "7day" => V1GetProjectUsageApiCountInterval.x7day,
                _ => null,
            };
        }
    }
}