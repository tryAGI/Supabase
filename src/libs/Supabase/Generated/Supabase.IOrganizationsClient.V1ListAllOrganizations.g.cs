#nullable enable

namespace Supabase
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// List all organizations<br/>
        /// Returns a list of organizations that you currently belong to.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Supabase.OrganizationResponseV1>> V1ListAllOrganizationsAsync(
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all organizations<br/>
        /// Returns a list of organizations that you currently belong to.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Supabase.OrganizationResponseV1>>> V1ListAllOrganizationsAsResponseAsync(
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}