
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1PgbouncerConfigResponsePoolMode
    {
        /// <summary>
        /// 
        /// </summary>
        Session,
        /// <summary>
        /// 
        /// </summary>
        Statement,
        /// <summary>
        /// 
        /// </summary>
        Transaction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1PgbouncerConfigResponsePoolModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1PgbouncerConfigResponsePoolMode value)
        {
            return value switch
            {
                V1PgbouncerConfigResponsePoolMode.Session => "session",
                V1PgbouncerConfigResponsePoolMode.Statement => "statement",
                V1PgbouncerConfigResponsePoolMode.Transaction => "transaction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1PgbouncerConfigResponsePoolMode? ToEnum(string value)
        {
            return value switch
            {
                "session" => V1PgbouncerConfigResponsePoolMode.Session,
                "statement" => V1PgbouncerConfigResponsePoolMode.Statement,
                "transaction" => V1PgbouncerConfigResponsePoolMode.Transaction,
                _ => null,
            };
        }
    }
}