namespace Supabase.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static SupabaseClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("SUPABASE_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("SUPABASE_API_KEY environment variable is not found.");

        var client = new SupabaseClient(apiKey);
        
        return client;
    }
}
