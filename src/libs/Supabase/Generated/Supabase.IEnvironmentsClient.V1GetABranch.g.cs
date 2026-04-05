#nullable enable

namespace Supabase
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Get a database branch<br/>
        /// Fetches the specified database branch by its name.
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.BranchResponse> V1GetABranchAsync(
            string @ref,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}