
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ListActionRunResponseOutputItemRunStepStatus
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
    public static class ListActionRunResponseOutputItemRunStepStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListActionRunResponseOutputItemRunStepStatus value)
        {
            return value switch
            {
                ListActionRunResponseOutputItemRunStepStatus.Created => "CREATED",
                ListActionRunResponseOutputItemRunStepStatus.Dead => "DEAD",
                ListActionRunResponseOutputItemRunStepStatus.Exited => "EXITED",
                ListActionRunResponseOutputItemRunStepStatus.Paused => "PAUSED",
                ListActionRunResponseOutputItemRunStepStatus.Removing => "REMOVING",
                ListActionRunResponseOutputItemRunStepStatus.Restarting => "RESTARTING",
                ListActionRunResponseOutputItemRunStepStatus.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListActionRunResponseOutputItemRunStepStatus? ToEnum(string value)
        {
            return value switch
            {
                "CREATED" => ListActionRunResponseOutputItemRunStepStatus.Created,
                "DEAD" => ListActionRunResponseOutputItemRunStepStatus.Dead,
                "EXITED" => ListActionRunResponseOutputItemRunStepStatus.Exited,
                "PAUSED" => ListActionRunResponseOutputItemRunStepStatus.Paused,
                "REMOVING" => ListActionRunResponseOutputItemRunStepStatus.Removing,
                "RESTARTING" => ListActionRunResponseOutputItemRunStepStatus.Restarting,
                "RUNNING" => ListActionRunResponseOutputItemRunStepStatus.Running,
                _ => null,
            };
        }
    }
}