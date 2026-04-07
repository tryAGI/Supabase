#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// Disables project's readonly mode for the next 15 minutes
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task V1DisableReadonlyModeTemporarilyAsync(
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}