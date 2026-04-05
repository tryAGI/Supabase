#nullable enable

namespace Supabase
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Gets project's service health status
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="services"></param>
        /// <param name="timeoutMs"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Supabase.V1ServiceHealthResponse>> V1GetServicesHealthAsync(
            string @ref,
            global::System.Collections.Generic.IList<global::Supabase.V1GetServicesHealthService> services,
            int? timeoutMs = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}