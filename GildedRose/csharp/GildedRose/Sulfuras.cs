namespace GildedRoseKata;

public class Sulfuras : Item
{
    public Sulfuras()
    {
        SellIn = -1;
        Name = "Sulfuras, Hand of Ragnaros";
        Quality = 80;
    }

    public override void UpdateQuality()
    {
    }

    public override bool IsExpired()
    {
        return false;
    }
    
    public override void DecrementQuality()
    {}
}