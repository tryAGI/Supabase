#nullable enable

namespace Supabase
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// List all organizations<br/>
        /// Returns a list of organizations that you currently belong to.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Supabase.OrganizationResponseV1>> V1ListAllOrganizationsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}