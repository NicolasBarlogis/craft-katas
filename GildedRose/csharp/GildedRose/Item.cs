namespace GildedRoseKata
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public override string ToString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality;
        }

        public bool IsExpired()
        {
            return SellIn < 0;
        }

        public void IncrementQuality()
        {
            if (Quality < 50)
            {
                Quality += 1;
            }
        }

        public void DecrementQuality()
        {
            if (Quality > 0)
            {
                Quality -= 1;
            }
        }

        public void DecrementSellIn()
        {
            SellIn -= 1;
        }

        public virtual void UpdateQuality()
        {
            switch (Name)
            {
                case "Sulfuras, Hand of Ragnaros":
                    {
                        break;
                    }
                default:
                    {
                        DecrementQuality();

                        DecrementSellIn();

                        if (IsExpired())
                        {
                            DecrementQuality();
                        }
                        break;
                    }
            }
        }
    }
}
