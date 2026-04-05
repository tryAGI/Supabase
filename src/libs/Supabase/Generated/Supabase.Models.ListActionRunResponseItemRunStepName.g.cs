
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListActionRunResponseItemRunStepName
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
    public static class ListActionRunResponseItemRunStepNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListActionRunResponseItemRunStepName value)
        {
            return value switch
            {
                ListActionRunResponseItemRunStepName.Clone => "clone",
                ListActionRunResponseItemRunStepName.Configure => "configure",
                ListActionRunResponseItemRunStepName.Deploy => "deploy",
                ListActionRunResponseItemRunStepName.Health => "health",
                ListActionRunResponseItemRunStepName.Migrate => "migrate",
                ListActionRunResponseItemRunStepName.Pull => "pull",
                ListActionRunResponseItemRunStepName.Seed => "seed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListActionRunResponseItemRunStepName? ToEnum(string value)
        {
            return value switch
            {
                "clone" => ListActionRunResponseItemRunStepName.Clone,
                "configure" => ListActionRunResponseItemRunStepName.Configure,
                "deploy" => ListActionRunResponseItemRunStepName.Deploy,
                "health" => ListActionRunResponseItemRunStepName.Health,
                "migrate" => ListActionRunResponseItemRunStepName.Migrate,
                "pull" => ListActionRunResponseItemRunStepName.Pull,
                "seed" => ListActionRunResponseItemRunStepName.Seed,
                _ => null,
            };
        }
    }
}