#nullable enable

namespace Supabase
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Gets all projects for the given organization<br/>
        /// Returns a paginated list of projects for the specified organization.<br/>
        /// This endpoint uses offset-based pagination. Use the `offset` parameter to skip a number of projects and the `limit` parameter to control the number of projects returned per page.
        /// </summary>
        /// <param name="slug">
        /// Example: tsrqponmlkjihgfedcba
        /// </param>
        /// <param name="offset">
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100<br/>
        /// Example: 20
        /// </param>
        /// <param name="search">
        /// Example: acme
        /// </param>
        /// <param name="sort">
        /// Default Value: name_asc<br/>
        /// Example: created_desc
        /// </param>
        /// <param name="statuses">
        /// Example: ACTIVE_HEALTHY,INACTIVE
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.OrganizationProjectsResponse> V1GetAllProjectsForOrganizationAsync(
            string slug,
            int? offset = default,
            int? limit = default,
            string? search = default,
            global::Supabase.V1GetAllProjectsForOrganizationSort? sort = default,
            string? statuses = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}