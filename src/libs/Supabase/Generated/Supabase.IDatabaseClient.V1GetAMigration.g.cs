#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// Fetch an existing entry from migration history<br/>
        /// Only available to selected partner OAuth apps
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="version"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.V1GetMigrationResponse> V1GetAMigrationAsync(
            string @ref,
            string version,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}