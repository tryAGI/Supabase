#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// Rollback database migrations and remove them from history table<br/>
        /// Only available to selected partner OAuth apps
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="gte"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task V1RollbackMigrationsAsync(
            string @ref,
            string gte,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}