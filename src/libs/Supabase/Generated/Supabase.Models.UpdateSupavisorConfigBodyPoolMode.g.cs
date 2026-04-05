
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Dedicated pooler mode for the project
    /// </summary>
    public enum UpdateSupavisorConfigBodyPoolMode
    {
        /// <summary>
        /// 
        /// </summary>
        Session,
        /// <summary>
        /// 
        /// </summary>
        Transaction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateSupavisorConfigBodyPoolModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSupavisorConfigBodyPoolMode value)
        {
            return value switch
            {
                UpdateSupavisorConfigBodyPoolMode.Session => "session",
                UpdateSupavisorConfigBodyPoolMode.Transaction => "transaction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSupavisorConfigBodyPoolMode? ToEnum(string value)
        {
            return value switch
            {
                "session" => UpdateSupavisorConfigBodyPoolMode.Session,
                "transaction" => UpdateSupavisorConfigBodyPoolMode.Transaction,
                _ => null,
            };
        }
    }
}