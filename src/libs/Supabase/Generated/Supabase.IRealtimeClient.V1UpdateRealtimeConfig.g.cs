#nullable enable

namespace Supabase
{
    public partial interface IRealtimeClient
    {
        /// <summary>
        /// Updates realtime configuration
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task V1UpdateRealtimeConfigAsync(
            string @ref,

            global::Supabase.UpdateRealtimeConfigBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates realtime configuration
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="privateOnly">
        /// Whether to only allow private channels
        /// </param>
        /// <param name="connectionPool">
        /// Sets connection pool size for Realtime Authorization
        /// </param>
        /// <param name="maxConcurrentUsers">
        /// Sets maximum number of concurrent users rate limit
        /// </param>
        /// <param name="maxEventsPerSecond">
        /// Sets maximum number of events per second rate per channel limit
        /// </param>
        /// <param name="maxBytesPerSecond">
        /// Sets maximum number of bytes per second rate per channel limit
        /// </param>
        /// <param name="maxChannelsPerClient">
        /// Sets maximum number of channels per client rate limit
        /// </param>
        /// <param name="maxJoinsPerSecond">
        /// Sets maximum number of joins per second rate limit
        /// </param>
        /// <param name="maxPresenceEventsPerSecond">
        /// Sets maximum number of presence events per second rate limit
        /// </param>
        /// <param name="maxPayloadSizeInKb">
        /// Sets maximum number of payload size in KB rate limit
        /// </param>
        /// <param name="suspend">
        /// Disables the Realtime service for this project when true. Set to false to re-enable it.
        /// </param>
        /// <param name="presenceEnabled">
        /// Whether to enable presence
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task V1UpdateRealtimeConfigAsync(
            string @ref,
            bool? privateOnly = default,
            int? connectionPool = default,
            int? maxConcurrentUsers = default,
            int? maxEventsPerSecond = default,
            long? maxBytesPerSecond = default,
            int? maxChannelsPerClient = default,
            int? maxJoinsPerSecond = default,
            int? maxPresenceEventsPerSecond = default,
            int? maxPayloadSizeInKb = default,
            bool? suspend = default,
            bool? presenceEnabled = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}