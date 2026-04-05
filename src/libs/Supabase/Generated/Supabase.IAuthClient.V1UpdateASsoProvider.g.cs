#nullable enable

namespace Supabase
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Updates a SSO provider by its UUID
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="providerId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.UpdateProviderResponse> V1UpdateASsoProviderAsync(
            string @ref,
            global::System.Guid providerId,

            global::Supabase.UpdateProviderBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a SSO provider by its UUID
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="providerId"></param>
        /// <param name="metadataXml"></param>
        /// <param name="metadataUrl"></param>
        /// <param name="domains"></param>
        /// <param name="attributeMapping"></param>
        /// <param name="nameIdFormat"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.UpdateProviderResponse> V1UpdateASsoProviderAsync(
            string @ref,
            global::System.Guid providerId,
            string? metadataXml = default,
            string? metadataUrl = default,
            global::System.Collections.Generic.IList<string>? domains = default,
            global::Supabase.UpdateProviderBodyAttributeMapping? attributeMapping = default,
            global::Supabase.UpdateProviderBodyNameIdFormat? nameIdFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}