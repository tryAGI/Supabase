#nullable enable

namespace Supabase
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// List all action runs<br/>
        /// Returns a paginated list of action runs of the specified project.
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Supabase.ListActionRunResponseItem>> V1ListActionRunsAsync(
            string @ref,
            double? offset = default,
            double? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}