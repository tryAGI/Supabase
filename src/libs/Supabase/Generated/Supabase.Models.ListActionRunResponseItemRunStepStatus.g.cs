
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListActionRunResponseItemRunStepStatus
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
    public static class ListActionRunResponseItemRunStepStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListActionRunResponseItemRunStepStatus value)
        {
            return value switch
            {
                ListActionRunResponseItemRunStepStatus.Created => "CREATED",
                ListActionRunResponseItemRunStepStatus.Dead => "DEAD",
                ListActionRunResponseItemRunStepStatus.Exited => "EXITED",
                ListActionRunResponseItemRunStepStatus.Paused => "PAUSED",
                ListActionRunResponseItemRunStepStatus.Removing => "REMOVING",
                ListActionRunResponseItemRunStepStatus.Restarting => "RESTARTING",
                ListActionRunResponseItemRunStepStatus.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListActionRunResponseItemRunStepStatus? ToEnum(string value)
        {
            return value switch
            {
                "CREATED" => ListActionRunResponseItemRunStepStatus.Created,
                "DEAD" => ListActionRunResponseItemRunStepStatus.Dead,
                "EXITED" => ListActionRunResponseItemRunStepStatus.Exited,
                "PAUSED" => ListActionRunResponseItemRunStepStatus.Paused,
                "REMOVING" => ListActionRunResponseItemRunStepStatus.Removing,
                "RESTARTING" => ListActionRunResponseItemRunStepStatus.Restarting,
                "RUNNING" => ListActionRunResponseItemRunStepStatus.Running,
                _ => null,
            };
        }
    }
}