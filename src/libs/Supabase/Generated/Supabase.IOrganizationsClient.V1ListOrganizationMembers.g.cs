#nullable enable

namespace Supabase
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// List members of an organization
        /// </summary>
        /// <param name="slug">
        /// Example: tsrqponmlkjihgfedcba
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Supabase.V1OrganizationMemberResponse>> V1ListOrganizationMembersAsync(
            string slug,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}