using Cupcakes;
using Xunit;

namespace CupcakeTest
{
    public class NameTest
    {
        [Fact]
        public void Should_correctName_When_CupcakeWithNoTopping()
        {
            Assert.Equal("🧁", (new Cupcake()).ToString());
        }
        
        [Fact]
        public void Should_correctName_When_CookieWithNoTopping()
        {
            Assert.Equal("🍪", (new Cookie()).ToString());
        }
        
        [Fact]
        public void Should_correctName_When_CupcakeWithChocolate()
        {
            Assert.Equal("🧁 with 🍫", (new Chocolate(new Cupcake())).ToString());
        }
        
        [Fact]
        public void Should_correctName_When_CookieWithChocolate()
        {
            Assert.Equal("🍪 with 🍫", (new Chocolate(new Cookie())).ToString());
        }
        
        [Fact]
        public void Should_correctName_When_CupcakeWithChocolateAndPeanut()
        {
            Assert.Equal("🧁 with 🍫 and 🥜", (new Peanut(new Chocolate(new Cupcake()))).ToString());
        }
        
        [Fact]
        public void Should_correctName_When_CupcakeWithPeanutAndChocolat()
        {
            Assert.Equal("🧁 with 🥜 and 🍫", (new Chocolate(new Peanut(new Cupcake()))).ToString());
        }
    }
}