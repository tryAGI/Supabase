#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Supabase
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// [Beta] Diffs a database branch<br/>
        /// Diffs the specified database branch
        /// </summary>
        /// <param name="branchIdOrRef"></param>
        /// <param name="includedSchemas"></param>
        /// <param name="pgdelta"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "SUPABASE_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<string> V1DiffABranchAsync(
            global::Supabase.OneOf<string, global::System.Guid?> branchIdOrRef,
            string? includedSchemas = default,
            bool? pgdelta = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}