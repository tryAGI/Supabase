
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum SupavisorConfigResponsePoolMode
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
    public static class SupavisorConfigResponsePoolModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SupavisorConfigResponsePoolMode value)
        {
            return value switch
            {
                SupavisorConfigResponsePoolMode.Session => "session",
                SupavisorConfigResponsePoolMode.Transaction => "transaction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SupavisorConfigResponsePoolMode? ToEnum(string value)
        {
            return value switch
            {
                "session" => SupavisorConfigResponsePoolMode.Session,
                "transaction" => SupavisorConfigResponsePoolMode.Transaction,
                _ => null,
            };
        }
    }
}