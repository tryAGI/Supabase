#nullable enable

namespace Supabase
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Gets information about the organization
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.V1OrganizationSlugResponse> V1GetAnOrganizationAsync(
            string slug,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}