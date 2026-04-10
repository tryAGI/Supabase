#nullable enable

namespace Supabase
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Get entitlements for an organization<br/>
        /// Returns the entitlements available to the organization based on their plan and any overrides.
        /// </summary>
        /// <param name="slug">
        /// Example: tsrqponmlkjihgfedcba
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.V1ListEntitlementsResponse> V1GetOrganizationEntitlementsAsync(
            string slug,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}