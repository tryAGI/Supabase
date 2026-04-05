#nullable enable

namespace Supabase
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Modify database disk
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task V1ModifyDatabaseDiskAsync(
            string @ref,

            global::Supabase.DiskRequestBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Modify database disk
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="attributes"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task V1ModifyDatabaseDiskAsync(
            string @ref,
            global::Supabase.Attributes2 attributes,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}