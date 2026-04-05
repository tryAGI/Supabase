#nullable enable

namespace Supabase
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Create an organization
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.OrganizationResponseV1> V1CreateAnOrganizationAsync(

            global::Supabase.CreateOrganizationV1 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an organization
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.OrganizationResponseV1> V1CreateAnOrganizationAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}