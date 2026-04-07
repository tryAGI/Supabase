#nullable enable

namespace Supabase
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Disables preview branching<br/>
        /// Disables preview branching for the specified project
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task V1DisablePreviewBranchingAsync(
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}