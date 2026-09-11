
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum V1PgbouncerConfigResponseOutputPoolMode
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
    public static class V1PgbouncerConfigResponseOutputPoolModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1PgbouncerConfigResponseOutputPoolMode value)
        {
            return value switch
            {
                V1PgbouncerConfigResponseOutputPoolMode.Session => "session",
                V1PgbouncerConfigResponseOutputPoolMode.Statement => "statement",
                V1PgbouncerConfigResponseOutputPoolMode.Transaction => "transaction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1PgbouncerConfigResponseOutputPoolMode? ToEnum(string value)
        {
            return value switch
            {
                "session" => V1PgbouncerConfigResponseOutputPoolMode.Session,
                "statement" => V1PgbouncerConfigResponseOutputPoolMode.Statement,
                "transaction" => V1PgbouncerConfigResponseOutputPoolMode.Transaction,
                _ => null,
            };
        }
    }
}