#nullable enable

namespace Supabase
{
    public partial interface IEdgeFunctionsClient
    {
        /// <summary>
        /// Bulk update functions<br/>
        /// Bulk update functions. It will create a new function or replace existing. The operation is idempotent. NOTE: You will need to manually bump the version.
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.BulkUpdateFunctionResponse> V1BulkUpdateFunctionsAsync(
            string @ref,

            global::System.Collections.Generic.IList<global::Supabase.BulkUpdateFunctionBodyItem> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}