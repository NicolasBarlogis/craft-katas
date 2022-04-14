namespace GildedRoseKata;

public class ConjuredItem : Item
{
    public override void DecrementQuality()
    {
        base.DecrementQuality();
        base.DecrementQuality();
    }
}