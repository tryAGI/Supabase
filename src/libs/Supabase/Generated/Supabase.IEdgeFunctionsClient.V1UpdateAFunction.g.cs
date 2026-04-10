#nullable enable

namespace Supabase
{
    public partial interface IEdgeFunctionsClient
    {
        /// <summary>
        /// Update a function<br/>
        /// Updates a function with the specified slug and project.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="functionSlug">
        /// Example: hello-world
        /// </param>
        /// <param name="slug">
        /// Example: hello-world
        /// </param>
        /// <param name="name">
        /// Example: Hello World
        /// </param>
        /// <param name="verifyJwt">
        /// Example: true
        /// </param>
        /// <param name="importMap">
        /// Example: false
        /// </param>
        /// <param name="entrypointPath">
        /// Example: index.ts
        /// </param>
        /// <param name="importMapPath">
        /// Example: import_map.json
        /// </param>
        /// <param name="ezbrSha256">
        /// Example: 44c691990518d25498f0fd80cf6631ecf2b58eb9c5eb2a087dd1688f2904dac7
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.FunctionResponse> V1UpdateAFunctionAsync(
            string @ref,
            string functionSlug,

            byte[] request,
            string? slug = default,
            string? name = default,
            bool? verifyJwt = default,
            bool? importMap = default,
            string? entrypointPath = default,
            string? importMapPath = default,
            string? ezbrSha256 = default,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}