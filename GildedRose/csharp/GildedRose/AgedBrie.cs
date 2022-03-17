namespace GildedRoseKata
{
    public class AgedBrie : Item
    {
        public AgedBrie()
        {
            Name = "Aged Brie";
        }

        public override void UpdateQuality()
        {
            IncrementQuality();
            DecrementSellIn();

            if (IsExpired())
            {
                IncrementQuality();
            }
        }
    }
}
