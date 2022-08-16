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
    }
}