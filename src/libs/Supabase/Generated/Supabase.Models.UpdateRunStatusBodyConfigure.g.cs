
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateRunStatusBodyConfigure
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
    public static class UpdateRunStatusBodyConfigureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRunStatusBodyConfigure value)
        {
            return value switch
            {
                UpdateRunStatusBodyConfigure.Created => "CREATED",
                UpdateRunStatusBodyConfigure.Dead => "DEAD",
                UpdateRunStatusBodyConfigure.Exited => "EXITED",
                UpdateRunStatusBodyConfigure.Paused => "PAUSED",
                UpdateRunStatusBodyConfigure.Removing => "REMOVING",
                UpdateRunStatusBodyConfigure.Restarting => "RESTARTING",
                UpdateRunStatusBodyConfigure.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRunStatusBodyConfigure? ToEnum(string value)
        {
            return value switch
            {
                "CREATED" => UpdateRunStatusBodyConfigure.Created,
                "DEAD" => UpdateRunStatusBodyConfigure.Dead,
                "EXITED" => UpdateRunStatusBodyConfigure.Exited,
                "PAUSED" => UpdateRunStatusBodyConfigure.Paused,
                "REMOVING" => UpdateRunStatusBodyConfigure.Removing,
                "RESTARTING" => UpdateRunStatusBodyConfigure.Restarting,
                "RUNNING" => UpdateRunStatusBodyConfigure.Running,
                _ => null,
            };
        }
    }
}