#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// List applied migration versions<br/>
        /// Only available to selected partner OAuth apps
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Supabase.V1ListMigrationsResponseItem>> V1ListMigrationHistoryAsync(
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}