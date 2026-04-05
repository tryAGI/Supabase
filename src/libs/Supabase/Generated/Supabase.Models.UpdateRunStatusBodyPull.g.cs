
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateRunStatusBodyPull
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
    public static class UpdateRunStatusBodyPullExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRunStatusBodyPull value)
        {
            return value switch
            {
                UpdateRunStatusBodyPull.Created => "CREATED",
                UpdateRunStatusBodyPull.Dead => "DEAD",
                UpdateRunStatusBodyPull.Exited => "EXITED",
                UpdateRunStatusBodyPull.Paused => "PAUSED",
                UpdateRunStatusBodyPull.Removing => "REMOVING",
                UpdateRunStatusBodyPull.Restarting => "RESTARTING",
                UpdateRunStatusBodyPull.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRunStatusBodyPull? ToEnum(string value)
        {
            return value switch
            {
                "CREATED" => UpdateRunStatusBodyPull.Created,
                "DEAD" => UpdateRunStatusBodyPull.Dead,
                "EXITED" => UpdateRunStatusBodyPull.Exited,
                "PAUSED" => UpdateRunStatusBodyPull.Paused,
                "REMOVING" => UpdateRunStatusBodyPull.Removing,
                "RESTARTING" => UpdateRunStatusBodyPull.Restarting,
                "RUNNING" => UpdateRunStatusBodyPull.Running,
                _ => null,
            };
        }
    }
}