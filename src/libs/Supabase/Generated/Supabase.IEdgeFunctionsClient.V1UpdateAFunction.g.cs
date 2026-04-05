#nullable enable

namespace Supabase
{
    public partial interface IEdgeFunctionsClient
    {
        /// <summary>
        /// Update a function<br/>
        /// Updates a function with the specified slug and project.
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="functionSlug"></param>
        /// <param name="slug"></param>
        /// <param name="name"></param>
        /// <param name="verifyJwt"></param>
        /// <param name="importMap"></param>
        /// <param name="entrypointPath"></param>
        /// <param name="importMapPath"></param>
        /// <param name="ezbrSha256"></param>
        /// <param name="request"></param>
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
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}