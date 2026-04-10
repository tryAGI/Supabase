#nullable enable

namespace Supabase
{
    public partial interface IEdgeFunctionsClient
    {
        /// <summary>
        /// Retrieve a function body<br/>
        /// Retrieves a function body for the specified slug and project.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="functionSlug">
        /// Example: hello-world
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.StreamableFile> V1GetAFunctionBodyAsync(
            string @ref,
            string functionSlug,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}