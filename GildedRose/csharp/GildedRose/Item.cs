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
                case "Backstage passes to a TAFKAL80ETC concert":
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

                        break;
                    }
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
