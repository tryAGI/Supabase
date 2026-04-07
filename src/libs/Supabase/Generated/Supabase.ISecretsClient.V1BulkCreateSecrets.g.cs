#nullable enable

namespace Supabase
{
    public partial interface ISecretsClient
    {
        /// <summary>
        /// Bulk create secrets<br/>
        /// Creates multiple secrets and adds them to the specified project.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task V1BulkCreateSecretsAsync(
            string @ref,

            global::System.Collections.Generic.IList<global::Supabase.CreateSecretBodyItem> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}