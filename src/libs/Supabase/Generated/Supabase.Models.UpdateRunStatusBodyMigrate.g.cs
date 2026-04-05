
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateRunStatusBodyMigrate
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
    public static class UpdateRunStatusBodyMigrateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRunStatusBodyMigrate value)
        {
            return value switch
            {
                UpdateRunStatusBodyMigrate.Created => "CREATED",
                UpdateRunStatusBodyMigrate.Dead => "DEAD",
                UpdateRunStatusBodyMigrate.Exited => "EXITED",
                UpdateRunStatusBodyMigrate.Paused => "PAUSED",
                UpdateRunStatusBodyMigrate.Removing => "REMOVING",
                UpdateRunStatusBodyMigrate.Restarting => "RESTARTING",
                UpdateRunStatusBodyMigrate.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRunStatusBodyMigrate? ToEnum(string value)
        {
            return value switch
            {
                "CREATED" => UpdateRunStatusBodyMigrate.Created,
                "DEAD" => UpdateRunStatusBodyMigrate.Dead,
                "EXITED" => UpdateRunStatusBodyMigrate.Exited,
                "PAUSED" => UpdateRunStatusBodyMigrate.Paused,
                "REMOVING" => UpdateRunStatusBodyMigrate.Removing,
                "RESTARTING" => UpdateRunStatusBodyMigrate.Restarting,
                "RUNNING" => UpdateRunStatusBodyMigrate.Running,
                _ => null,
            };
        }
    }
}