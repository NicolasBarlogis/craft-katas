using GildedRoseKata;

namespace GildedRoseTests
{
    public class BackstagePassTests
    {
        [Theory]
        [InlineData(10)]
        [InlineData(6)]
        public void WhenTheConcertDateIsLessThanTenDaysAndMoreThanFive_ThenTheQualityContinueIncreaseTwice(int sellIn)
        {
            // Arrange
            const int baseQuality = 25;

            var backstagePass = new BackstagePass
            {
                Quality = baseQuality,
                SellIn = sellIn
            };

            // Act
            backstagePass.UpdateQuality();

            // Assert
            Assert.Equal(baseQuality + 2, backstagePass.Quality);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(1)]
        public void WhenTheConcertDateIsLessThanFiveDaysAndMoreThanZero_ThenTheQualityContinueIncreaseByThree(int sellIn)
        {
            // Arrange
            const int baseQuality = 25;

            var backstagePass = new BackstagePass
            {
                Quality = baseQuality,
                SellIn = sellIn
            };

            // Act
            backstagePass.UpdateQuality();

            // Assert
            Assert.Equal(baseQuality + 3, backstagePass.Quality);
        }

        [Fact]
        public void WhenTheConcertDateIsMoreThanTenDays_ThenTheQualityContinueIncreaseOnce()
        {
            // Arrange
            const int baseQuality = 25;

            var backstagePass = new BackstagePass
            {
                Quality = baseQuality,
                SellIn = 11
            };

            // Act
            backstagePass.UpdateQuality();

            // Assert
            Assert.Equal(baseQuality + 1, backstagePass.Quality);
        }

        [Fact]
        public void WhenTheConcertDateHasPassed_ThenTheQualityContinueIncreaseOnce()
        {
            // Arrange
            const int baseQuality = 25;

            var backstagePass = new BackstagePass
            {
                Quality = baseQuality,
                SellIn = 0
            };

            // Act
            backstagePass.UpdateQuality();

            // Assert
            Assert.Equal(0, backstagePass.Quality);
        }
    }
}
