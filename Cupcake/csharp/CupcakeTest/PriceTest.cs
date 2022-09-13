using Cupcakes;
using Xunit;

namespace CupcakeTest
{
    public class PriceTest
    {
        [Fact]
        public void Should_have_correct_price_When_cupcake()
        {
            Assert.Equal(1, new Cookie().GetPrice());
        }
    }
}

/*### About price function or method

-The price function should return 1$ for “🧁”
-   The price function should return 2$ for “🍪”
-   The price function should return 1.1$ for “🧁 with 🍫”
-   The price function should return 2.1$ for “🍪 with 🍫”
-   The price function should return 2.2$ for “🍪 with 🥜”*/