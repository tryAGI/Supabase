#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// Updates project's supavisor config
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.UpdateSupavisorConfigResponse> V1UpdatePoolerConfigAsync(
            string @ref,

            global::Supabase.UpdateSupavisorConfigBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates project's supavisor config
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="defaultPoolSize"></param>
        /// <param name="poolMode">
        /// Dedicated pooler mode for the project
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.UpdateSupavisorConfigResponse> V1UpdatePoolerConfigAsync(
            string @ref,
            int? defaultPoolSize = default,
            global::Supabase.UpdateSupavisorConfigBodyPoolMode? poolMode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}