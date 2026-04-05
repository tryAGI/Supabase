#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// Apply a database migration<br/>
        /// Only available to selected partner OAuth apps
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="idempotencyKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task V1ApplyAMigrationAsync(
            string @ref,

            global::Supabase.V1CreateMigrationBody request,
            string? idempotencyKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Apply a database migration<br/>
        /// Only available to selected partner OAuth apps
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="idempotencyKey"></param>
        /// <param name="query"></param>
        /// <param name="name"></param>
        /// <param name="rollback"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task V1ApplyAMigrationAsync(
            string @ref,
            string query,
            string? idempotencyKey = default,
            string? name = default,
            string? rollback = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}