#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// Get project's pgbouncer config
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.V1PgbouncerConfigResponse> V1GetProjectPgbouncerConfigAsync(
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}