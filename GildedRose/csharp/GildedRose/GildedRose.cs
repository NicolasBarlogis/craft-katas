namespace GildedRoseKata
{
    public class GildedRose
    {
        private readonly IList<Item> _items;

        public GildedRose(IList<Item> items)
        {
            _items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                switch (item.Name)
                {
                    case "Aged Brie":
                    {
                            item.IncrementQuality();

                            item.SellIn -= 1;
                            
                        if (item.IsExpired()) {
                            item.IncrementQuality();
                        }

                        break;
                    }
                    case "Backstage passes to a TAFKAL80ETC concert":
                        {
                            item.IncrementQuality();
                            if (item.SellIn < 11)
                            {
                                item.IncrementQuality();
                            }

                            if (item.SellIn < 6)
                            {
                                item.IncrementQuality();
                            }

                            item.SellIn -= 1;

                            if (item.IsExpired())
                            {
                                item.Quality = 0;
                            }

                            break;
                        }
                    case "Sulfuras, Hand of Ragnaros":
                    {
                        break;
                    }
                    default:
                    {
                        item.DecrementQuality();

                        item.SellIn -= 1;

                        if (item.IsExpired())
                        {
                            item.DecrementQuality();
                        }
                        break;
                    }
                }
            }
        }
    }
}
