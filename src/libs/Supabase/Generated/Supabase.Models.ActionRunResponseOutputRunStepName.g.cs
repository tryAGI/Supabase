
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ActionRunResponseOutputRunStepName
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
    public static class ActionRunResponseOutputRunStepNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionRunResponseOutputRunStepName value)
        {
            return value switch
            {
                ActionRunResponseOutputRunStepName.Clone => "clone",
                ActionRunResponseOutputRunStepName.Configure => "configure",
                ActionRunResponseOutputRunStepName.Deploy => "deploy",
                ActionRunResponseOutputRunStepName.Health => "health",
                ActionRunResponseOutputRunStepName.Migrate => "migrate",
                ActionRunResponseOutputRunStepName.Pull => "pull",
                ActionRunResponseOutputRunStepName.Seed => "seed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionRunResponseOutputRunStepName? ToEnum(string value)
        {
            return value switch
            {
                "clone" => ActionRunResponseOutputRunStepName.Clone,
                "configure" => ActionRunResponseOutputRunStepName.Configure,
                "deploy" => ActionRunResponseOutputRunStepName.Deploy,
                "health" => ActionRunResponseOutputRunStepName.Health,
                "migrate" => ActionRunResponseOutputRunStepName.Migrate,
                "pull" => ActionRunResponseOutputRunStepName.Pull,
                "seed" => ActionRunResponseOutputRunStepName.Seed,
                _ => null,
            };
        }
    }
}