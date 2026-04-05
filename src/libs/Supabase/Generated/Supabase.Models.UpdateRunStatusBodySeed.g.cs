
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateRunStatusBodySeed
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Dead,
        /// <summary>
        /// 
        /// </summary>
        Exited,
        /// <summary>
        /// 
        /// </summary>
        Paused,
        /// <summary>
        /// 
        /// </summary>
        Removing,
        /// <summary>
        /// 
        /// </summary>
        Restarting,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateRunStatusBodySeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRunStatusBodySeed value)
        {
            return value switch
            {
                UpdateRunStatusBodySeed.Created => "CREATED",
                UpdateRunStatusBodySeed.Dead => "DEAD",
                UpdateRunStatusBodySeed.Exited => "EXITED",
                UpdateRunStatusBodySeed.Paused => "PAUSED",
                UpdateRunStatusBodySeed.Removing => "REMOVING",
                UpdateRunStatusBodySeed.Restarting => "RESTARTING",
                UpdateRunStatusBodySeed.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRunStatusBodySeed? ToEnum(string value)
        {
            return value switch
            {
                "CREATED" => UpdateRunStatusBodySeed.Created,
                "DEAD" => UpdateRunStatusBodySeed.Dead,
                "EXITED" => UpdateRunStatusBodySeed.Exited,
                "PAUSED" => UpdateRunStatusBodySeed.Paused,
                "REMOVING" => UpdateRunStatusBodySeed.Removing,
                "RESTARTING" => UpdateRunStatusBodySeed.Restarting,
                "RUNNING" => UpdateRunStatusBodySeed.Running,
                _ => null,
            };
        }
    }
}