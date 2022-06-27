using Order_Shipping.Domain;
using Order_Shipping.Domain.Exception;
using Xunit;

namespace OrderShippingTest.Domain
{
    public class QuantityTest
    {
        [Fact]
        public void QuantityTest_ValueShouldBeNotNegative()
        {
            Assert.Throws<QuantityCantBeNegativeException>(() => new Quantity(-10));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(10)]
        public void QuantityTest_ValueShouldBePositif(int qte)
        {
            Quantity quantity =new(qte);
            Assert.Equal(quantity.Value,qte);
        }
    }
}
