using GildedRoseKata;

namespace GildedRoseTests;

public class SulfurasTests
{
    [Fact]
    public void DecrementQuality_ShouldDoNothing()
    {
        //Arrange
        Sulfuras sulfuras = new();
        var expectedQuality = sulfuras.Quality;

        //Act
        sulfuras.DecrementQuality();

        //Assert
        Assert.Equal(expectedQuality, sulfuras.Quality);
    }

    [Fact]
    public void Quality_ShouldBe80()
    {
        //Arrange
        Sulfuras sulfuras = new();

        //Act
        sulfuras.UpdateQuality();

        //Assert
        Assert.Equal(80, sulfuras.Quality);
    }

    [Fact]
    public void IsExpired_ShouldBeFalse()
    {
        //Arrange
        Sulfuras sulfuras = new();

        //Act
        var isExpired = sulfuras.IsExpired();

        //Assert
        Assert.False(isExpired);
    }
}