#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// List all user-id to role mappings for JIT access<br/>
        /// Mappings of roles a user can assume in the project database
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.JitListAccessResponse> V1ListJitAccessAsync(
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}