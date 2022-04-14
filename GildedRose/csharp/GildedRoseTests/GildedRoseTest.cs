using System.Text;
using GildedRoseKata;
using Newtonsoft.Json;

namespace GildedRoseTests;

[UsesVerify]
public class GildedRoseTest
{
    public GildedRoseTest()
    {
        VerifierSettings.ModifySerialization(settings =>
            settings.AddExtraSettings(serializerSettings =>
                serializerSettings.DefaultValueHandling = DefaultValueHandling.Include));
    }

    // [Fact]
    // public Task GoldenMaster_Main()
    // {
    //     StringBuilder sb = new();
    //     using StringWriter stream = new(sb);
    //
    //     Console.SetOut(stream);
    //     Program.Main(Array.Empty<string>());
    //
    //     return Verify(sb.ToString());
    // }
}
