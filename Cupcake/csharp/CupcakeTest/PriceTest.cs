using Cupcakes;
using Xunit;

namespace CupcakeTest
{
    public class PriceTest
    {
        [Fact]
        public void Should_have_correct_price_when_cupcake()
        {
            Assert.Equal(1, new Cupcake().GetPrice());
        }

        [Fact]
        public void Should_have_correct_price_when_cookie()
        {
            Assert.Equal(2, new Cookie().GetPrice());
        }

        [Fact]
        public void Should_have_correct_price_when_cupcake_with_chocolate()
        {
            Assert.Equal((decimal)1.1, new Cupcake(new Chocolate()).GetPrice());
        }

        [Fact]
        public void Should_have_correct_price_when_cookie_with_chocolate()
        {
            Assert.Equal((decimal)2.1, new Cookie(new Chocolate()).GetPrice());
        }

        [Fact]
        public void Should_have_correct_price_when_cookie_with_peanuts()
        {
            Assert.Equal((decimal)2.2, new Cookie(new Peanut()).GetPrice());
        }

        [Fact]
        public void Should_have_correct_price_when_cookie_with_peanut_and_chocolate()
        {
            Assert.Equal((decimal)2.3, new Cookie(new Peanut(new Chocolate())).GetPrice());
        }

        [Fact]
        public void Should_have_correct_correct_price_When_cookie_with_three_chocolate_and_two_peanuts()
        {
            Assert.Equal((decimal)1.7, new Cupcake(new Chocolate(new Chocolate(new Chocolate(new Peanut(new Peanut()))))).GetPrice());
        }
    }
}

/*### About price function or method

-The price function should return 1$ for “🧁”
-   The price function should return 2$ for “🍪”
-   The price function should return 1.1$ for “🧁 with 🍫”
-   The price function should return 2.1$ for “🍪 with 🍫”
-   The price function should return 2.2$ for “🍪 with 🥜”*/