#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// Updates a user mapping for JIT access<br/>
        /// Modifies the roles that can be assumed and for how long
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.JitAccessResponse> V1UpdateJitAccessAsync(
            string @ref,

            global::Supabase.UpdateJitAccessBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a user mapping for JIT access<br/>
        /// Modifies the roles that can be assumed and for how long
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="userId"></param>
        /// <param name="roles"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.JitAccessResponse> V1UpdateJitAccessAsync(
            string @ref,
            global::System.Guid userId,
            global::System.Collections.Generic.IList<global::Supabase.UpdateJitAccessBodyRole> roles,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}