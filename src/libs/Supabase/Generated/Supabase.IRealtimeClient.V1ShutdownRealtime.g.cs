#nullable enable

namespace Supabase
{
    public partial interface IRealtimeClient
    {
        /// <summary>
        /// Shutdowns realtime connections for a project
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task V1ShutdownRealtimeAsync(
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}