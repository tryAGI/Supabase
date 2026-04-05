#nullable enable

namespace Supabase
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Updates the given project
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.V1ProjectRefResponse> V1UpdateAProjectAsync(
            string @ref,

            global::Supabase.V1UpdateProjectBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates the given project
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.V1ProjectRefResponse> V1UpdateAProjectAsync(
            string @ref,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}