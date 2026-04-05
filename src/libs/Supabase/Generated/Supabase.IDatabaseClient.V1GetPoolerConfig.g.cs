#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// Gets project's supavisor config
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Supabase.SupavisorConfigResponse>> V1GetPoolerConfigAsync(
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}