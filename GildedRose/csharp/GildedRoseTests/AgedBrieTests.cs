using GildedRoseKata;

namespace GildedRoseTests
{
    public class AgedBrieTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void WhenTheAgedBrieIsExpired_ThenTheQualityContinueToIncreaseTwice(int sellIn)
        {
            // Arrange
            const int baseQuality = 25;
            
            var agedBrie = new AgedBrie
            {
                SellIn = sellIn,
                Quality = baseQuality
            };

            // Act
            agedBrie.UpdateQuality();

            // Assert
            Assert.Equal(baseQuality + 2, agedBrie.Quality);
        }

        [Fact]
        public void WhenTheAgedBrieIsNotExpired_ThenTheQualityContinueToIncreaseOnce()
        {
            // Arrange
            const int baseQuality = 25;

            var agedBrie = new AgedBrie
            {
                SellIn = 1,
                Quality = baseQuality
            };

            // Act
            agedBrie.UpdateQuality();

            // Assert
            Assert.Equal(baseQuality + 1, agedBrie.Quality);
        }
    }
}
