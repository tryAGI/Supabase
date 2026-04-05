
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateRunStatusBodyHealth
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
    public static class UpdateRunStatusBodyHealthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRunStatusBodyHealth value)
        {
            return value switch
            {
                UpdateRunStatusBodyHealth.Created => "CREATED",
                UpdateRunStatusBodyHealth.Dead => "DEAD",
                UpdateRunStatusBodyHealth.Exited => "EXITED",
                UpdateRunStatusBodyHealth.Paused => "PAUSED",
                UpdateRunStatusBodyHealth.Removing => "REMOVING",
                UpdateRunStatusBodyHealth.Restarting => "RESTARTING",
                UpdateRunStatusBodyHealth.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRunStatusBodyHealth? ToEnum(string value)
        {
            return value switch
            {
                "CREATED" => UpdateRunStatusBodyHealth.Created,
                "DEAD" => UpdateRunStatusBodyHealth.Dead,
                "EXITED" => UpdateRunStatusBodyHealth.Exited,
                "PAUSED" => UpdateRunStatusBodyHealth.Paused,
                "REMOVING" => UpdateRunStatusBodyHealth.Removing,
                "RESTARTING" => UpdateRunStatusBodyHealth.Restarting,
                "RUNNING" => UpdateRunStatusBodyHealth.Running,
                _ => null,
            };
        }
    }
}