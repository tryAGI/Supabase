#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// Delete JIT access by user-id<br/>
        /// Remove JIT mappings of a user, revoking all JIT database access
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="userId">
        /// Example: 55555555-5555-4555-8555-555555555555
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task V1DeleteJitAccessAsync(
            string @ref,
            global::System.Guid userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}