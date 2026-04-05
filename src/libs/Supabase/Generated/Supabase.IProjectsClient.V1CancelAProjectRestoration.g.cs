#nullable enable

namespace Supabase
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Cancels the given project restoration
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task V1CancelAProjectRestorationAsync(
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}