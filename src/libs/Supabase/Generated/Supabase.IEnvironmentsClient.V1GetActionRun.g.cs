#nullable enable

namespace Supabase
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Get the status of an action run<br/>
        /// Returns the current status of the specified action run.
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.ActionRunResponse> V1GetActionRunAsync(
            string @ref,
            string runId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}