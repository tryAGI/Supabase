
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Postgres engine version. If not provided, the latest version will be used.
    /// </summary>
    public enum CreateBranchBodyPostgresEngine
    {
        /// <summary>
        /// 
        /// </summary>
        x15,
        /// <summary>
        /// 
        /// </summary>
        x17,
        /// <summary>
        /// 
        /// </summary>
        x17Oriole,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateBranchBodyPostgresEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBranchBodyPostgresEngine value)
        {
            return value switch
            {
                CreateBranchBodyPostgresEngine.x15 => "15",
                CreateBranchBodyPostgresEngine.x17 => "17",
                CreateBranchBodyPostgresEngine.x17Oriole => "17-oriole",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBranchBodyPostgresEngine? ToEnum(string value)
        {
            return value switch
            {
                "15" => CreateBranchBodyPostgresEngine.x15,
                "17" => CreateBranchBodyPostgresEngine.x17,
                "17-oriole" => CreateBranchBodyPostgresEngine.x17Oriole,
                _ => null,
            };
        }
    }
}