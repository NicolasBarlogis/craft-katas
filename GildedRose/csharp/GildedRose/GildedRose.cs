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
                if (item.Name == "Aged Brie")
                {
                    if (item.Quality < 50)
                    {
                        item.Quality += 1;
                    }

                    item.SellIn -= 1;

                    if (item.SellIn < 0 && item.Quality < 50)
                    {
                        item.Quality += 1;
                    }
                }
                else
                {
                    if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
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

                        if (item.SellIn >= 0)
                        {
                            continue;
                        }

                        item.Quality -= item.Quality;
                    }
                    else
                    {
                        if (item.Name == "Sulfuras, Hand of Ragnaros")
                        {
                            if (item.SellIn >= 0 || item.Quality <= 0)
                            {
                                continue;
                            }
                        }
                        else
                        {
                            if (item.Quality > 0)
                            {
                                item.Quality -= 1;
                            }

                            item.SellIn -= 1;

                            if (item.SellIn >= 0 || item.Quality <= 0)
                            {
                                continue;
                            }

                            item.Quality -= 1;
                        }
                    }
                }
            }
        }
    }
}
