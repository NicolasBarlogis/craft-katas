using System;
using Cupcakes;
using Xunit;

namespace CupcakeTest
{
    public class PriceTest
    {
        [Fact]
        public void Should_correctPrice_When_CupcakeWithNoTopping()
        {
            Assert.Equal(1.0, (new Cupcake().GetPrice()));
        }
        
        [Fact]
        public void Should_correctPrice_When_CookieWithNoTopping()
        {
            Assert.Equal(2.0, (new Cookie().GetPrice()));
        }
        
        [Fact]
        public void Should_correctPrice_When_CupcakeWithChocolate()
        {
            Assert.Equal(1.1, (new Chocolate(new Cupcake()).GetPrice()));
        }
        
        [Fact]
        public void Should_correctPrice_When_CookieWithChocolate()
        {
            Assert.Equal(2.1, (new Chocolate(new Cookie()).GetPrice()));
        }
        
        [Fact]
        public void Should_correctPrice_When_CookieWithPeanut()
        {
            Assert.Equal(2.2, (new Peanut(new Cookie()).GetPrice()));
        }
        
        [Fact]
        public void Should_correctPrice_When_CookieWithPeanutAndChocolate()
        {
            Assert.Equal(2.3, Math.Round(new Chocolate(new Peanut(new Cookie())).GetPrice(),1));
        }
    }
}