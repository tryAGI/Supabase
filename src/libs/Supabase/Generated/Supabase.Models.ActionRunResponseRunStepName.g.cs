
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActionRunResponseRunStepName
    {
        /// <summary>
        /// 
        /// </summary>
        Clone,
        /// <summary>
        /// 
        /// </summary>
        Configure,
        /// <summary>
        /// 
        /// </summary>
        Deploy,
        /// <summary>
        /// 
        /// </summary>
        Health,
        /// <summary>
        /// 
        /// </summary>
        Migrate,
        /// <summary>
        /// 
        /// </summary>
        Pull,
        /// <summary>
        /// 
        /// </summary>
        Seed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionRunResponseRunStepNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionRunResponseRunStepName value)
        {
            return value switch
            {
                ActionRunResponseRunStepName.Clone => "clone",
                ActionRunResponseRunStepName.Configure => "configure",
                ActionRunResponseRunStepName.Deploy => "deploy",
                ActionRunResponseRunStepName.Health => "health",
                ActionRunResponseRunStepName.Migrate => "migrate",
                ActionRunResponseRunStepName.Pull => "pull",
                ActionRunResponseRunStepName.Seed => "seed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionRunResponseRunStepName? ToEnum(string value)
        {
            return value switch
            {
                "clone" => ActionRunResponseRunStepName.Clone,
                "configure" => ActionRunResponseRunStepName.Configure,
                "deploy" => ActionRunResponseRunStepName.Deploy,
                "health" => ActionRunResponseRunStepName.Health,
                "migrate" => ActionRunResponseRunStepName.Migrate,
                "pull" => ActionRunResponseRunStepName.Pull,
                "seed" => ActionRunResponseRunStepName.Seed,
                _ => null,
            };
        }
    }
}