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

    [Fact]
    public Task foo()
    {
        IList<Item> Items = new List<Item> { new() { Name = "foo", SellIn = 0, Quality = 0 } };
        var gildedRose = new GildedRose(Items);
        gildedRose.UpdateQuality();
        return Verify(Items);
    }
}