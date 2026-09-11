
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ListActionRunResponseOutputItemRunStepName
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
    public static class ListActionRunResponseOutputItemRunStepNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListActionRunResponseOutputItemRunStepName value)
        {
            return value switch
            {
                ListActionRunResponseOutputItemRunStepName.Clone => "clone",
                ListActionRunResponseOutputItemRunStepName.Configure => "configure",
                ListActionRunResponseOutputItemRunStepName.Deploy => "deploy",
                ListActionRunResponseOutputItemRunStepName.Health => "health",
                ListActionRunResponseOutputItemRunStepName.Migrate => "migrate",
                ListActionRunResponseOutputItemRunStepName.Pull => "pull",
                ListActionRunResponseOutputItemRunStepName.Seed => "seed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListActionRunResponseOutputItemRunStepName? ToEnum(string value)
        {
            return value switch
            {
                "clone" => ListActionRunResponseOutputItemRunStepName.Clone,
                "configure" => ListActionRunResponseOutputItemRunStepName.Configure,
                "deploy" => ListActionRunResponseOutputItemRunStepName.Deploy,
                "health" => ListActionRunResponseOutputItemRunStepName.Health,
                "migrate" => ListActionRunResponseOutputItemRunStepName.Migrate,
                "pull" => ListActionRunResponseOutputItemRunStepName.Pull,
                "seed" => ListActionRunResponseOutputItemRunStepName.Seed,
                _ => null,
            };
        }
    }
}