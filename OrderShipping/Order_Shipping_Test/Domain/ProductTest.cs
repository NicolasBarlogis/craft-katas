using OrderShipping.Domain;
using Xunit;

namespace OrderShippingTest.Domain;

public class ProductTest
{
    public ProductTest()
    {
    }

    [Fact]
    public void SaladShouldHaveACorrectTax()
    {
        // Arrange
        var food = new Category("food", 10m);

        Product salad = new()
        {
            Name = "salad",
            Price = 3.56m,
            Category = food
        };

        // Assert
        Assert.Equal(0.36m, salad.Tax(), 2);
    }

    [Fact]
    public void SaladShouldHaveACorrectTaxedAmount()
    {
        // Arrange
        var food = new Category("food", 10m);

        Product salad = new()
        {
            Name = "salad",
            Price = 3.56m,
            Category = food
        };

        // Assert
        Assert.Equal(3.92m, salad.Taxed(), 2);
    }
}
