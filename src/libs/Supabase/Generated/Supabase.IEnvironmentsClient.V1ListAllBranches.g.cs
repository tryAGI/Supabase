#nullable enable

namespace Supabase
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// List all database branches<br/>
        /// Returns all database branches of the specified project.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Supabase.BranchResponse>> V1ListAllBranchesAsync(
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}