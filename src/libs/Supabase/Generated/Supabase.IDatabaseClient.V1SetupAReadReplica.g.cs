#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// [Beta] Set up a read replica
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "SUPABASE_BETA_001")]
#endif
        global::System.Threading.Tasks.Task V1SetupAReadReplicaAsync(
            string @ref,

            global::Supabase.SetUpReadReplicaBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [Beta] Set up a read replica
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="readReplicaRegion">
        /// Region you want your read replica to reside in<br/>
        /// Example: us-east-1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "SUPABASE_BETA_001")]
#endif
        global::System.Threading.Tasks.Task V1SetupAReadReplicaAsync(
            string @ref,
            global::Supabase.SetUpReadReplicaBodyReadReplicaRegion readReplicaRegion,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}