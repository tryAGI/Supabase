#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// Initiates an undo to a given restore point
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task V1UndoAsync(
            string @ref,

            global::Supabase.V1UndoBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Initiates an undo to a given restore point
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task V1UndoAsync(
            string @ref,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}