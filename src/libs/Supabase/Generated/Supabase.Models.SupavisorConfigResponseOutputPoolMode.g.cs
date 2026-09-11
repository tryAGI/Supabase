
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum SupavisorConfigResponseOutputPoolMode
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
    public static class SupavisorConfigResponseOutputPoolModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SupavisorConfigResponseOutputPoolMode value)
        {
            return value switch
            {
                SupavisorConfigResponseOutputPoolMode.Session => "session",
                SupavisorConfigResponseOutputPoolMode.Transaction => "transaction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SupavisorConfigResponseOutputPoolMode? ToEnum(string value)
        {
            return value switch
            {
                "session" => SupavisorConfigResponseOutputPoolMode.Session,
                "transaction" => SupavisorConfigResponseOutputPoolMode.Transaction,
                _ => null,
            };
        }
    }
}