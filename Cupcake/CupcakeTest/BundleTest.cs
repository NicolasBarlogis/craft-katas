using System;
using Cupcakes;
using Xunit;

namespace CupcakeTest
{
    public class BundleTest
    {
        [Fact]
        public void Should_have_correctName_When_BundleOfOneCupcakeWithNoTopping()
        {
            var bundle = new Bundle.Bundle();
            bundle.Add(new Cupcake());
            Assert.Equal("Bundle [ 🧁 ]", bundle.ToString());
        }
        
        [Fact]
        public void Should_have_correctPrice_When_BundleOfOneCupcakeWithNoTopping()
        {
            var bundle = new Bundle.Bundle();
            bundle.Add(new Cupcake());
            Assert.Equal(1.0, bundle.GetPrice());
        }
        
        [Fact]
        public void Should_have_correctName_When_BundleOfOneCupcakeWithNoToppingAndOneCookieWithNoTopping()
        {
            var bundle = new Bundle.Bundle();
            bundle.Add(new Cupcake());
            bundle.Add(new Cookie());
            Assert.Equal("Bundle [ 🧁, 🍪 ]", bundle.ToString());
        }

        [Fact]
        public void Should_have_correctPrice_When_BundleOfOneCupcakeWithNoToppingAndOneCookieWithNoTopping()
        {
            var bundle = new Bundle.Bundle();
            bundle.Add(new Cupcake());
            bundle.Add(new Cookie());
            Assert.Equal(3.0, bundle.GetPrice());
        }
        
        [Fact]
        public void Should_have_correctName_When_BundleOfOneCupcakeWithChocolatAndOneCookieWithNoTopping()
        {
            var bundle = new Bundle.Bundle();
            bundle.Add(new Chocolate(new Cupcake()));
            bundle.Add(new Cookie());
            Assert.Equal("Bundle [ 🧁 with 🍫, 🍪 ]", bundle.ToString());
        }
        
        [Fact]
        public void Should_have_correctPrice_When_BundleOfOneCupcakeWithChocolatAndOneCookieWithNoTopping()
        {
            var bundle = new Bundle.Bundle();
            bundle.Add(new Chocolate(new Cupcake()));
            bundle.Add(new Cookie());
            Assert.Equal(3.1, bundle.GetPrice());
        }
        
        [Fact]
        public void Should_have_correctName_When_BundleOfTwoCupcakesWithNoToppingAndOneCookieWithNoTopping()
        {
            var bundle = new Bundle.Bundle();
            bundle.Add(new Cupcake());
            bundle.Add(new Cupcake());
            bundle.Add(new Cookie());
            Assert.Equal("Bundle [ 🧁, 🧁, 🍪 ]", bundle.ToString());
        }
        
        [Fact]
        public void Should_have_correctPrice_When_BundleOfTowCupcakeWithNoToppingAndOneCookieWithNoTopping()
        {
            var bundle = new Bundle.Bundle();
            bundle.Add(new Cupcake());
            bundle.Add(new Cupcake());
            bundle.Add(new Cookie());
            Assert.Equal(4.0, bundle.GetPrice());
        }
        
        [Fact]
        public void Should_have_correctName_When_BundleOfBundleOfTwoCupcakesWithNoToppingAndOneCookieWithNoTopping()
        {
            var bundle = new Bundle.Bundle();
            bundle.Add(new Cupcake());
            bundle.Add(new Cupcake());
            var maxiBundle = new Bundle.Bundle();
            maxiBundle.Add(bundle);
            maxiBundle.Add(new Cookie());
            Assert.Equal("Bundle [ Bundle [ 🧁, 🧁 ], 🍪 ]", maxiBundle.ToString());
        }
        
        [Fact]
        public void Should_have_correctPrice_When_BundleOfBundleOfTwoCupcakesWithNoToppingAndOneCookieWithNoTopping()
        {
            var bundle = new Bundle.Bundle();
            bundle.Add(new Cupcake());
            bundle.Add(new Cupcake());
            var maxiBundle = new Bundle.Bundle();
            maxiBundle.Add(bundle);
            maxiBundle.Add(new Cookie());
            Assert.Equal(4.0, maxiBundle.GetPrice());
        }
        
        [Fact]
        public void Should_have_correctName_When_BundleOfBundleOfTwoCupcakesWithNoToppingAndOneCookieWithChocolateAndPeanut()
        {
            var bundle = new Bundle.Bundle();
            bundle.Add(new Cupcake());
            bundle.Add(new Cupcake());
            var maxiBundle = new Bundle.Bundle();
            maxiBundle.Add(bundle);
            maxiBundle.Add(new Peanut(new Chocolate(new Cookie())));
            Assert.Equal("Bundle [ Bundle [ 🧁, 🧁 ], 🍪 with 🍫 and 🥜 ]", maxiBundle.ToString());
        }
        
        [Fact]
        public void Should_have_correctPrice_When_BundleOfBundleOfTwoCupcakesWithNoToppingAndOneCookieWithChocolateAndPeanut()
        {
            var bundle = new Bundle.Bundle();
            bundle.Add(new Cupcake());
            bundle.Add(new Cupcake());
            var maxiBundle = new Bundle.Bundle();
            maxiBundle.Add(bundle);
            maxiBundle.Add(new Peanut(new Chocolate(new Cookie())));
            Assert.Equal(4.3, Math.Round(maxiBundle.GetPrice(),1));
        }
    }
}