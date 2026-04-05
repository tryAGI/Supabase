#nullable enable

namespace Supabase
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// List all projects<br/>
        /// Returns a list of all projects you've previously created.<br/>
        /// Use `/v1/organizations/{slug}/projects` instead when possible to get more precise results and pagination support.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Supabase.V1ProjectWithDatabaseResponse>> V1ListAllProjectsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}