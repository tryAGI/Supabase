#nullable enable

namespace Supabase
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Apply or update billing addons, including compute instance size<br/>
        /// Selects an addon variant, for example scaling the project’s compute instance up or down, and applies it to the project.
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task V1ApplyProjectAddonAsync(
            string @ref,

            global::Supabase.ApplyProjectAddonBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Apply or update billing addons, including compute instance size<br/>
        /// Selects an addon variant, for example scaling the project’s compute instance up or down, and applies it to the project.
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="addonVariant"></param>
        /// <param name="addonType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task V1ApplyProjectAddonAsync(
            string @ref,
            global::Supabase.OneOf<global::Supabase.ApplyProjectAddonBodyAddonVariantVariant1?, global::Supabase.ApplyProjectAddonBodyAddonVariantVariant2?, global::Supabase.ApplyProjectAddonBodyAddonVariantVariant3?, global::Supabase.ApplyProjectAddonBodyAddonVariantVariant4?> addonVariant,
            global::Supabase.ApplyProjectAddonBodyAddonType addonType,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}