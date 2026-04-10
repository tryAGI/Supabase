#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Supabase
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Restore a scheduled branch deletion<br/>
        /// Cancels scheduled deletion and restores the branch to active state
        /// </summary>
        /// <param name="branchIdOrRef">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.BranchRestoreResponse> V1RestoreABranchAsync(
            global::Supabase.OneOf<string, global::System.Guid?> branchIdOrRef,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}