using GildedRoseKata;

namespace GildedRoseTests;

public class ConjuredItemTest
{
    [Fact]
    public void WhenItemIsConjured_ItsQualityShouldDecreaseTwiceAsFastAsNormalItems()
    {
        // Arrange
        Item conjuredItem = new ConjuredItem
        {
            Quality = 4
        };

        // Act
        conjuredItem.DecrementQuality();

        // Assert
        Assert.Equal(2, conjuredItem.Quality);
    }

    [Fact]
    public void WhenItemIsExpired_ItsQualityShouldDecreaseTwiceAsFastAsNormalItems()
    {
        // Arrange
        Item conjuredItem = new ConjuredItem
        {
            SellIn = 0,
            Quality = 4
        };

        // Act
        conjuredItem.UpdateQuality();

        // Assert
        Assert.Equal(0, conjuredItem.Quality);
    }
    
    [Fact]
    public void WhenItemIsExpiredAndQualityLow_ItsQualityShouldGotoZero()
    {
        // Arrange
        Item conjuredItem = new ConjuredItem
        {
            SellIn = 0,
            Quality = 2
        };

        // Act
        conjuredItem.UpdateQuality();

        // Assert
        Assert.Equal(0, conjuredItem.Quality);
    }
    
    [Fact]
    public void WhenItemWillExpireNextDayAndQualityisLow_ItsQualityShouldGotoZero()
    {
        // Arrange
        Item conjuredItem = new ConjuredItem
        {
            SellIn = 1,
            Quality = 3
        };

        // Act
        conjuredItem.UpdateQuality();
        conjuredItem.UpdateQuality();

        // Assert
        Assert.Equal(0, conjuredItem.Quality);
    }
}
