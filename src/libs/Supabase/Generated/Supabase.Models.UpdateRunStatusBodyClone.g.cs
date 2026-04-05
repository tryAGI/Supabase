
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateRunStatusBodyClone
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
    public static class UpdateRunStatusBodyCloneExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRunStatusBodyClone value)
        {
            return value switch
            {
                UpdateRunStatusBodyClone.Created => "CREATED",
                UpdateRunStatusBodyClone.Dead => "DEAD",
                UpdateRunStatusBodyClone.Exited => "EXITED",
                UpdateRunStatusBodyClone.Paused => "PAUSED",
                UpdateRunStatusBodyClone.Removing => "REMOVING",
                UpdateRunStatusBodyClone.Restarting => "RESTARTING",
                UpdateRunStatusBodyClone.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRunStatusBodyClone? ToEnum(string value)
        {
            return value switch
            {
                "CREATED" => UpdateRunStatusBodyClone.Created,
                "DEAD" => UpdateRunStatusBodyClone.Dead,
                "EXITED" => UpdateRunStatusBodyClone.Exited,
                "PAUSED" => UpdateRunStatusBodyClone.Paused,
                "REMOVING" => UpdateRunStatusBodyClone.Removing,
                "RESTARTING" => UpdateRunStatusBodyClone.Restarting,
                "RUNNING" => UpdateRunStatusBodyClone.Running,
                _ => null,
            };
        }
    }
}