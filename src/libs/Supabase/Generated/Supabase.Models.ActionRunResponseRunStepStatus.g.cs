
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActionRunResponseRunStepStatus
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
    public static class ActionRunResponseRunStepStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionRunResponseRunStepStatus value)
        {
            return value switch
            {
                ActionRunResponseRunStepStatus.Created => "CREATED",
                ActionRunResponseRunStepStatus.Dead => "DEAD",
                ActionRunResponseRunStepStatus.Exited => "EXITED",
                ActionRunResponseRunStepStatus.Paused => "PAUSED",
                ActionRunResponseRunStepStatus.Removing => "REMOVING",
                ActionRunResponseRunStepStatus.Restarting => "RESTARTING",
                ActionRunResponseRunStepStatus.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionRunResponseRunStepStatus? ToEnum(string value)
        {
            return value switch
            {
                "CREATED" => ActionRunResponseRunStepStatus.Created,
                "DEAD" => ActionRunResponseRunStepStatus.Dead,
                "EXITED" => ActionRunResponseRunStepStatus.Exited,
                "PAUSED" => ActionRunResponseRunStepStatus.Paused,
                "REMOVING" => ActionRunResponseRunStepStatus.Removing,
                "RESTARTING" => ActionRunResponseRunStepStatus.Restarting,
                "RUNNING" => ActionRunResponseRunStepStatus.Running,
                _ => null,
            };
        }
    }
}