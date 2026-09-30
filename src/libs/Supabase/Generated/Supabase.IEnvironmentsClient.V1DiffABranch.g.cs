#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Supabase
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Diffs a database branch<br/>
        /// Diffs the specified database branch<br/>
        /// This endpoint is currently in its **Beta** stage.
        /// </summary>
        /// <param name="branchIdOrRef">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="includedSchemas">
        /// Example: public,auth
        /// </param>
        /// <param name="pgdelta">
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> V1DiffABranchAsync(
            global::Supabase.AnyOf<string, global::System.Guid?> branchIdOrRef,
            string? includedSchemas = default,
            string? pgdelta = default,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Diffs a database branch<br/>
        /// Diffs the specified database branch<br/>
        /// This endpoint is currently in its **Beta** stage.
        /// </summary>
        /// <param name="branchIdOrRef">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="includedSchemas">
        /// Example: public,auth
        /// </param>
        /// <param name="pgdelta">
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.AutoSDKHttpResponse<string>> V1DiffABranchAsResponseAsync(
            global::Supabase.AnyOf<string, global::System.Guid?> branchIdOrRef,
            string? includedSchemas = default,
            string? pgdelta = default,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}