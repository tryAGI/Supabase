#nullable enable

namespace Supabase
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Remove billing addons or revert compute instance sizing<br/>
        /// Disables the selected addon variant, including rolling the compute instance back to its previous size.
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="addonVariant"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task V1RemoveProjectAddonAsync(
            string @ref,
            global::Supabase.OneOf<global::Supabase.V1RemoveProjectAddonAddonVariantVariant1?, global::Supabase.V1RemoveProjectAddonAddonVariantVariant2?, global::Supabase.V1RemoveProjectAddonAddonVariantVariant3?, global::Supabase.V1RemoveProjectAddonAddonVariantVariant4?> addonVariant,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}