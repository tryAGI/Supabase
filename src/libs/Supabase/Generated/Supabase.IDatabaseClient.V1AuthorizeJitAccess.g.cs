#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// Authorize user-id to role mappings for JIT access<br/>
        /// Authorizes the request to assume a role in the project database
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.JitAuthorizeAccessResponse> V1AuthorizeJitAccessAsync(
            string @ref,

            global::Supabase.AuthorizeJitAccessBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Authorize user-id to role mappings for JIT access<br/>
        /// Authorizes the request to assume a role in the project database
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="role"></param>
        /// <param name="rhost"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.JitAuthorizeAccessResponse> V1AuthorizeJitAccessAsync(
            string @ref,
            string role,
            string rhost,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}