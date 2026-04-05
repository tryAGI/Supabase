#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// [Beta] Run sql query
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "SUPABASE_BETA_001")]
#endif
        global::System.Threading.Tasks.Task V1RunAQueryAsync(
            string @ref,

            global::Supabase.V1RunQueryBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [Beta] Run sql query
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <param name="readOnly"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "SUPABASE_BETA_001")]
#endif
        global::System.Threading.Tasks.Task V1RunAQueryAsync(
            string @ref,
            string query,
            global::System.Collections.Generic.IList<object>? parameters = default,
            bool? readOnly = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}