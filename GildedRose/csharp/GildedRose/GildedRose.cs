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
                        if (item.Quality < 50)
                        {
                            item.Quality += 1;
                        }

                        item.SellIn -= 1;
                            
                        if (item.IsExpired() && item.Quality < 50)
                        {
                            item.Quality += 1;
                        }

                        break;
                    }
                    case "Backstage passes to a TAFKAL80ETC concert":
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality += 1;

                            if (item.SellIn < 11 && item.Quality < 50)
                            {
                                item.Quality += 1;
                            }

                            if (item.SellIn < 6 && item.Quality < 50)
                            {
                                item.Quality += 1;
                            }
                        }

                        item.SellIn -= 1;

                        if (item.IsExpired())
                        {
                            item.Quality -= item.Quality;
                        }

                        break;
                    }
                    case "Sulfuras, Hand of Ragnaros":
                    {
                        break;
                    }
                    default:
                    {
                        if (item.Quality > 0)
                        {
                            item.Quality -= 1;
                        }

                        item.SellIn -= 1;

                        if (item.IsExpired() && item.Quality > 0)
                        {
                            item.Quality -= 1;
                        }

                        break;
                    }
                }
            }
        }
    }
}
