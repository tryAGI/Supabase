#nullable enable

namespace Supabase
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Gets project details for the specified organization and claim token
        /// </summary>
        /// <param name="slug">
        /// Example: tsrqponmlkjihgfedcba
        /// </param>
        /// <param name="token">
        /// Example: 0123456789abcdef0123456789abcdef01234567
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.OrganizationProjectClaimResponse> V1GetOrganizationProjectClaimAsync(
            string slug,
            string token,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}