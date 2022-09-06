using Cupcakes;
using Xunit;

namespace CupcakeTest
{
    public class NameTest
    {
        [Fact]
        public void Should_have_correct_name_When_cupcake_with_no_topping()
        {
            Assert.Equal("🧁", (new Cupcake()).ToString());
        }

        [Fact]
        public void Should_have_correct_name_When_cookie_with_no_topping()
        {
            Assert.Equal("🍪", (new Cookie()).ToString());
        }

        [Fact]
        public void Should_have_correct_name_When_cupcake_with_chocolate()
        {
            Assert.Equal("🧁 with 🍫", new Cupcake(new Chocolate()).ToString());
        }

        [Fact]
        public void Should_have_correct_name_When_cookie_with_chocolate()
        {
            Assert.Equal("🍪 with 🍫", new Cookie(new Chocolate()).ToString());
        }

        [Fact]
        public void Should_have_correct_name_When_cookie_with_peanut()
        {
            Assert.Equal("🍪 with 🥜", new Cookie(new Peanut()).ToString());
        }

        [Fact]
        public void Should_have_correct_name_When_cookie_with_chocolate_and_peanut()
        {
            Assert.Equal("🍪 with 🍫 and 🥜", new Cookie(new Chocolate(new Peanut())).ToString());
        }

        [Fact]
        public void Should_have_correct_name_When_cookie_with_peanut_and_chocolate()
        {
            Assert.Equal("🍪 with 🥜 and 🍫", new Cookie(new Peanut(new Chocolate())).ToString());
        }
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