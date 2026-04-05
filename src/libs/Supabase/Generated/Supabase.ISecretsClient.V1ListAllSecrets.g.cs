#nullable enable

namespace Supabase
{
    public partial interface ISecretsClient
    {
        /// <summary>
        /// List all secrets<br/>
        /// Returns all secrets you've previously added to the specified project.
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Supabase.SecretResponse>> V1ListAllSecretsAsync(
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}