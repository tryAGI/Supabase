#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// Upsert a database migration without applying<br/>
        /// Only available to selected partner OAuth apps
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="idempotencyKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task V1UpsertAMigrationAsync(
            string @ref,

            global::Supabase.V1UpsertMigrationBody request,
            string? idempotencyKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert a database migration without applying<br/>
        /// Only available to selected partner OAuth apps
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="idempotencyKey"></param>
        /// <param name="query"></param>
        /// <param name="name"></param>
        /// <param name="rollback"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task V1UpsertAMigrationAsync(
            string @ref,
            string query,
            string? idempotencyKey = default,
            string? name = default,
            string? rollback = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}