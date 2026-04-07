#nullable enable

namespace Supabase
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// List billing addons and compute instance selections<br/>
        /// Returns the billing addons that are currently applied, including the active compute instance size, and lists every addon option that can be provisioned with pricing metadata.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.ListProjectAddonsResponse> V1ListProjectAddonsAsync(
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}