#nullable enable

namespace Supabase
{
    public partial interface IEdgeFunctionsClient
    {
        /// <summary>
        /// List all functions<br/>
        /// Returns all functions you've previously added to the specified project.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Supabase.FunctionResponse>> V1ListAllFunctionsAsync(
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}