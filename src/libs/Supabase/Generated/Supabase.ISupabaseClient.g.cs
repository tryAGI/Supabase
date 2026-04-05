
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Supabase API generated from the OpenAPI specification.Visit [https://supabase.com/docs](https://supabase.com/docs) for a complete documentation.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ISupabaseClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


        /// <summary>
        /// Analytics related endpoints
        /// </summary>
        public AnalyticsClient Analytics { get; }

        /// <summary>
        /// Auth related endpoints
        /// </summary>
        public AuthClient Auth { get; }

        /// <summary>
        /// Billing related endpoints
        /// </summary>
        public BillingClient Billing { get; }

        /// <summary>
        /// Database related endpoints
        /// </summary>
        public DatabaseClient Database { get; }

        /// <summary>
        /// Domains related endpoints
        /// </summary>
        public DomainsClient Domains { get; }

        /// <summary>
        /// Edge related endpoints
        /// </summary>
        public EdgeFunctionsClient EdgeFunctions { get; }

        /// <summary>
        /// Environments related endpoints
        /// </summary>
        public EnvironmentsClient Environments { get; }

        /// <summary>
        /// OAuth related endpoints
        /// </summary>
        public OAuthClient OAuth { get; }

        /// <summary>
        /// Organizations related endpoints
        /// </summary>
        public OrganizationsClient Organizations { get; }

        /// <summary>
        /// Projects related endpoints
        /// </summary>
        public ProjectsClient Projects { get; }

        /// <summary>
        /// 
        /// </summary>
        public RealtimeClient Realtime { get; }

        /// <summary>
        /// Rest related endpoints
        /// </summary>
        public RestClient Rest { get; }

        /// <summary>
        /// Secrets related endpoints
        /// </summary>
        public SecretsClient Secrets { get; }

        /// <summary>
        /// Visit [https://supabase.github.io/storage/](https://supabase.github.io/storage/) for complete documentation.
        /// </summary>
        public StorageClient Storage { get; }

    }
}