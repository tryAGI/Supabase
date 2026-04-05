#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// Returns project's readonly mode status
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.ReadOnlyStatusResponse> V1GetReadonlyModeStatusAsync(
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}