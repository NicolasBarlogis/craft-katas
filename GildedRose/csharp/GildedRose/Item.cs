﻿namespace GildedRoseKata
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
    }
}
