#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Supabase
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Update database branch config<br/>
        /// Updates the configuration of the specified database branch
        /// </summary>
        /// <param name="branchIdOrRef">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.BranchResponse> V1UpdateABranchConfigAsync(
            global::Supabase.OneOf<string, global::System.Guid?> branchIdOrRef,

            global::Supabase.UpdateBranchBody request,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update database branch config<br/>
        /// Updates the configuration of the specified database branch
        /// </summary>
        /// <param name="branchIdOrRef">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="branchName"></param>
        /// <param name="gitBranch"></param>
        /// <param name="persistent"></param>
        /// <param name="status"></param>
        /// <param name="requestReview"></param>
        /// <param name="notifyUrl">
        /// HTTP endpoint to receive branch status updates.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.BranchResponse> V1UpdateABranchConfigAsync(
#pragma warning disable CS0618 // Type or member is obsolete
            global::Supabase.OneOf<string, global::System.Guid?> branchIdOrRef,
#pragma warning disable CS0618 // Type or member is obsolete
            string? branchName = default,
            string? gitBranch = default,
            bool? persistent = default,
            global::Supabase.UpdateBranchBodyStatus? status = default,
            bool? requestReview = default,
            string? notifyUrl = default,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}