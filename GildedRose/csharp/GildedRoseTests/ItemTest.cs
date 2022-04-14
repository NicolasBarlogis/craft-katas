using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseTests
{

    public class ItemTest
    {
        private readonly ConjuredItemTest _conjuredItemTest = new ConjuredItemTest();

        [Fact]
        public void WhenQualityNotAtMax_ShouldIncrementIt()
        {
            //Arrange
            Item item = new()
            {
                Quality = 48
            };

            //Act
            item.IncrementQuality();

            //Asserts
            Assert.Equal(49, item.Quality);
        }

        [Fact]
        public void WhenQualityAtMax_ShouldIncrementIt()
        {
            //Arrange
            Item item = new()
            {
                Quality = 50
            };

            //Act
            item.IncrementQuality();

            //Asserts
            Assert.Equal(50, item.Quality);
        }

        [Fact]
        public void WhenQualityGreaterThanZero_ShouldDecrementIt()
        {
            //Arrange
            Item item = new()
            {
                Quality = 48
            };

            //Act
            item.DecrementQuality();

            //Asserts
            Assert.Equal(47, item.Quality);
        }

        [Fact]
        public void WhenQualityEqualToZero_ShouldNotDecrementIt()
        {
            //Arrange
            Item item = new()
            {
                Quality = 0
            };

            //Act
            item.DecrementQuality();

            //Asserts
            Assert.Equal(0, item.Quality);
        }

        [Fact]
        public void WhenSellInExpired_ShouldReturnTrue()
        {
            //Arrange
            Item item = new()
            {
                SellIn = -1
            };

            //Act
            bool isExpired = item.IsExpired();

            //Assert
            Assert.True(isExpired);
        }

        [Fact]
        public void WhenSellInNotExpired_ShouldReturnFalse()
        {
            //Arrange
            Item item = new()
            {
                SellIn = 0
            };

            //Act
            bool isExpired = item.IsExpired();

            //Assert
            Assert.False(isExpired);
        }

    }
}
