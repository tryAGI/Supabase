using tryAGI.Supabase;

namespace Supabase.IntegrationTests;

public partial class Examples
{
    [TestMethod]
    public void AIFunctions()
    {
        //// Use Supabase tools with any MEAI-compatible AI provider
        using var client = new SupabaseClient(apiKey: "test");
        var tools = client.AsTools();
        tools.Count.Should().BeGreaterThan(0);
    }
}
