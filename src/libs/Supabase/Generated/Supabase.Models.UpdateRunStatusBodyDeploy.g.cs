
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateRunStatusBodyDeploy
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
    public static class UpdateRunStatusBodyDeployExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRunStatusBodyDeploy value)
        {
            return value switch
            {
                UpdateRunStatusBodyDeploy.Created => "CREATED",
                UpdateRunStatusBodyDeploy.Dead => "DEAD",
                UpdateRunStatusBodyDeploy.Exited => "EXITED",
                UpdateRunStatusBodyDeploy.Paused => "PAUSED",
                UpdateRunStatusBodyDeploy.Removing => "REMOVING",
                UpdateRunStatusBodyDeploy.Restarting => "RESTARTING",
                UpdateRunStatusBodyDeploy.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRunStatusBodyDeploy? ToEnum(string value)
        {
            return value switch
            {
                "CREATED" => UpdateRunStatusBodyDeploy.Created,
                "DEAD" => UpdateRunStatusBodyDeploy.Dead,
                "EXITED" => UpdateRunStatusBodyDeploy.Exited,
                "PAUSED" => UpdateRunStatusBodyDeploy.Paused,
                "REMOVING" => UpdateRunStatusBodyDeploy.Removing,
                "RESTARTING" => UpdateRunStatusBodyDeploy.Restarting,
                "RUNNING" => UpdateRunStatusBodyDeploy.Running,
                _ => null,
            };
        }
    }
}