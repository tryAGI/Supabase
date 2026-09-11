
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ActionRunResponseOutputRunStepStatus
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
    public static class ActionRunResponseOutputRunStepStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionRunResponseOutputRunStepStatus value)
        {
            return value switch
            {
                ActionRunResponseOutputRunStepStatus.Created => "CREATED",
                ActionRunResponseOutputRunStepStatus.Dead => "DEAD",
                ActionRunResponseOutputRunStepStatus.Exited => "EXITED",
                ActionRunResponseOutputRunStepStatus.Paused => "PAUSED",
                ActionRunResponseOutputRunStepStatus.Removing => "REMOVING",
                ActionRunResponseOutputRunStepStatus.Restarting => "RESTARTING",
                ActionRunResponseOutputRunStepStatus.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionRunResponseOutputRunStepStatus? ToEnum(string value)
        {
            return value switch
            {
                "CREATED" => ActionRunResponseOutputRunStepStatus.Created,
                "DEAD" => ActionRunResponseOutputRunStepStatus.Dead,
                "EXITED" => ActionRunResponseOutputRunStepStatus.Exited,
                "PAUSED" => ActionRunResponseOutputRunStepStatus.Paused,
                "REMOVING" => ActionRunResponseOutputRunStepStatus.Removing,
                "RESTARTING" => ActionRunResponseOutputRunStepStatus.Restarting,
                "RUNNING" => ActionRunResponseOutputRunStepStatus.Running,
                _ => null,
            };
        }
    }
}