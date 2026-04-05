#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// Lists all backups
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.V1BackupsResponse> V1ListAllBackupsAsync(
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}