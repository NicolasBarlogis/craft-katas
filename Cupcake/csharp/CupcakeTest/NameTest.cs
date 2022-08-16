using Cupcake;
using Xunit;

namespace CupcakeTest
{
    public class NameTest
    {
        [Fact]
        public void Should_have_correct_name_When_cupcake_with_no_topping()
        {
            Assert.Equal("🧁", (new Cupcake.Cupcake()).ToString());
        }

        [Fact]
        public void Should_have_correct_name_When_cookie_with_no_topping()
        {
            Assert.Equal("🍪", (new Cookie()).ToString());
        }

        [Fact]
        public void Should_have_correct_name_When_cupcake_with_chocolate()
        {
            Assert.Equal("🧁 with 🍫", new Cupcake.Cupcake(new Chocolate()).ToString());
        }
    }

    public class Chocolate
    {
    }
}

/*
 ### About name function or method

-The name function should return “🧁”
-   The name function should return “🍪”
-   The name function should return “🧁 with 🍫”
-   The name function should return “🍪 with 🍫”
-   The name function should return “🍪 with 🍫 and 🥜”
-   The name function should return “🍪 with 🥜 and 🍫”
*/