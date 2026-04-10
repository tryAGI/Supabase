#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// [Beta] Run a sql query as supabase_read_only_user<br/>
        /// All entity references must be schema qualified.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "SUPABASE_BETA_001")]
#endif
        global::System.Threading.Tasks.Task V1ReadOnlyQueryAsync(
            string @ref,

            global::Supabase.V1ReadOnlyQueryBody request,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [Beta] Run a sql query as supabase_read_only_user<br/>
        /// All entity references must be schema qualified.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "SUPABASE_BETA_001")]
#endif
        global::System.Threading.Tasks.Task V1ReadOnlyQueryAsync(
            string @ref,
            string query,
            global::System.Collections.Generic.IList<object>? parameters = default,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}