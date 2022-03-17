namespace GildedRoseKata;

public class BackstagePass : Item
{
    public BackstagePass()
    {
        Name = "Backstage passes to a TAFKAL80ETC concert";
    }

    public override void UpdateQuality()
    {
        IncrementQuality();

        if (SellIn < 11)
        {
            IncrementQuality();
        }

        if (SellIn < 6)
        {
            IncrementQuality();
        }

        DecrementSellIn();

        if (IsExpired())
        {
            Quality = 0;
        }
    }
}