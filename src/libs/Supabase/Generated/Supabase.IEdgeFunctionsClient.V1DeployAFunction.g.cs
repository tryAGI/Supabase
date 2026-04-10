#nullable enable

namespace Supabase
{
    public partial interface IEdgeFunctionsClient
    {
        /// <summary>
        /// Deploy a function<br/>
        /// A new endpoint to deploy functions. It will create if function does not exist.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="slug">
        /// Example: hello-world
        /// </param>
        /// <param name="bundleOnly">
        /// Example: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.DeployFunctionResponse> V1DeployAFunctionAsync(
            string @ref,

            global::Supabase.FunctionDeployBody request,
            string? slug = default,
            bool? bundleOnly = default,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deploy a function<br/>
        /// A new endpoint to deploy functions. It will create if function does not exist.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="slug">
        /// Example: hello-world
        /// </param>
        /// <param name="bundleOnly">
        /// Example: false
        /// </param>
        /// <param name="file"></param>
        /// <param name="metadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.DeployFunctionResponse> V1DeployAFunctionAsync(
            string @ref,
            global::Supabase.FunctionDeployBodyMetadata metadata,
            string? slug = default,
            bool? bundleOnly = default,
            global::System.Collections.Generic.IList<byte[]>? file = default,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}