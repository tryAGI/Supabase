#nullable enable

namespace Supabase
{
    public partial interface IEdgeFunctionsClient
    {
        /// <summary>
        /// Deploy a function<br/>
        /// A new endpoint to deploy functions. It will create if function does not exist.
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="slug"></param>
        /// <param name="bundleOnly"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.DeployFunctionResponse> V1DeployAFunctionAsync(
            string @ref,

            global::Supabase.FunctionDeployBody request,
            string? slug = default,
            bool? bundleOnly = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deploy a function<br/>
        /// A new endpoint to deploy functions. It will create if function does not exist.
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="slug"></param>
        /// <param name="bundleOnly"></param>
        /// <param name="file"></param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.DeployFunctionResponse> V1DeployAFunctionAsync(
            string @ref,
            global::Supabase.FunctionDeployBodyMetadata metadata,
            string? slug = default,
            bool? bundleOnly = default,
            global::System.Collections.Generic.IList<byte[]>? file = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}