#nullable enable

namespace Supabase
{
    public partial interface IRealtimeClient
    {
        /// <summary>
        /// Gets realtime configuration
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.RealtimeConfigResponse> V1GetRealtimeConfigAsync(
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}