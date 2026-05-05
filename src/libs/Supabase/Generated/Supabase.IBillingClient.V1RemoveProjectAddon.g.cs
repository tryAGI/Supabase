#nullable enable

namespace Supabase
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Remove billing addons or revert compute instance sizing<br/>
        /// Disables the selected addon variant, including rolling the compute instance back to its previous size.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="addonVariant">
        /// Example: pitr_7
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task V1RemoveProjectAddonAsync(
            string @ref,
            global::Supabase.OneOf<global::Supabase.V1RemoveProjectAddonAddonVariantVariant1?, global::Supabase.V1RemoveProjectAddonAddonVariantVariant2?, global::Supabase.V1RemoveProjectAddonAddonVariantVariant3?, global::Supabase.V1RemoveProjectAddonAddonVariantVariant4?> addonVariant,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove billing addons or revert compute instance sizing<br/>
        /// Disables the selected addon variant, including rolling the compute instance back to its previous size.
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="addonVariant">
        /// Example: pitr_7
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.AutoSDKHttpResponse> V1RemoveProjectAddonAsResponseAsync(
            string @ref,
            global::Supabase.OneOf<global::Supabase.V1RemoveProjectAddonAddonVariantVariant1?, global::Supabase.V1RemoveProjectAddonAddonVariantVariant2?, global::Supabase.V1RemoveProjectAddonAddonVariantVariant3?, global::Supabase.V1RemoveProjectAddonAddonVariantVariant4?> addonVariant,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}