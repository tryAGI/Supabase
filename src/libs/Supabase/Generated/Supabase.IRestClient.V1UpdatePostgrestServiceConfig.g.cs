#nullable enable

namespace Supabase
{
    public partial interface IRestClient
    {
        /// <summary>
        /// Updates project's postgrest config
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.V1PostgrestConfigResponse> V1UpdatePostgrestServiceConfigAsync(
            string @ref,

            global::Supabase.V1UpdatePostgrestConfigBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates project's postgrest config
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="dbExtraSearchPath"></param>
        /// <param name="dbSchema"></param>
        /// <param name="maxRows"></param>
        /// <param name="dbPool"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.V1PostgrestConfigResponse> V1UpdatePostgrestServiceConfigAsync(
            string @ref,
            string? dbExtraSearchPath = default,
            string? dbSchema = default,
            int? maxRows = default,
            int? dbPool = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}