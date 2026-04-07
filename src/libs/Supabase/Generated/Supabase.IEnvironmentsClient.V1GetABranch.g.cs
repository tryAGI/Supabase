#nullable enable

namespace Supabase
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Get a database branch<br/>
        /// Fetches the specified database branch by its name.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="name">
        /// Example: preview-login-page
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.BranchResponse> V1GetABranchAsync(
            string @ref,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}