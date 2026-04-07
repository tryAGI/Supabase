#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// Restores a PITR backup for a database
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task V1RestorePitrBackupAsync(
            string @ref,

            global::Supabase.V1RestorePitrBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Restores a PITR backup for a database
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="recoveryTimeTargetUnix"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task V1RestorePitrBackupAsync(
            string @ref,
            long recoveryTimeTargetUnix,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}