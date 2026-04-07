#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// Patch an existing entry in migration history<br/>
        /// Only available to selected partner OAuth apps
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="version">
        /// Example: 20250312000000
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task V1PatchAMigrationAsync(
            string @ref,
            string version,

            global::Supabase.V1PatchMigrationBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch an existing entry in migration history<br/>
        /// Only available to selected partner OAuth apps
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="version">
        /// Example: 20250312000000
        /// </param>
        /// <param name="name"></param>
        /// <param name="rollback"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task V1PatchAMigrationAsync(
            string @ref,
            string version,
            string? name = default,
            string? rollback = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}