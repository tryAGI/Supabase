
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Default Value: name_asc
    /// </summary>
    public enum V1GetAllProjectsForOrganizationSort
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAsc,
        /// <summary>
        /// 
        /// </summary>
        CreatedDesc,
        /// <summary>
        /// 
        /// </summary>
        NameAsc,
        /// <summary>
        /// 
        /// </summary>
        NameDesc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1GetAllProjectsForOrganizationSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1GetAllProjectsForOrganizationSort value)
        {
            return value switch
            {
                V1GetAllProjectsForOrganizationSort.CreatedAsc => "created_asc",
                V1GetAllProjectsForOrganizationSort.CreatedDesc => "created_desc",
                V1GetAllProjectsForOrganizationSort.NameAsc => "name_asc",
                V1GetAllProjectsForOrganizationSort.NameDesc => "name_desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1GetAllProjectsForOrganizationSort? ToEnum(string value)
        {
            return value switch
            {
                "created_asc" => V1GetAllProjectsForOrganizationSort.CreatedAsc,
                "created_desc" => V1GetAllProjectsForOrganizationSort.CreatedDesc,
                "name_asc" => V1GetAllProjectsForOrganizationSort.NameAsc,
                "name_desc" => V1GetAllProjectsForOrganizationSort.NameDesc,
                _ => null,
            };
        }
    }
}