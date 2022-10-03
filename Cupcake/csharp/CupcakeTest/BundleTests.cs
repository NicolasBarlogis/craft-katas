using System.Collections.Generic;
using Cupcakes;
using Xunit;

namespace CupcakeTest;

public sealed class BundleTests
{
    [Fact]
    public void We_Can_Build_An_Empty_Bundle_And_Check_Price_Or_Description()
    {
        Bundle bundle = new();
        
        Assert.Equal(0, bundle.GetPrice());
        Assert.Equal("empty 📦", bundle.ToString());
    }

    [Fact]
    public void We_Can_Build_A_Bundle_With_One_Cupcake_And_Check_Price_Or_Description()
    {
        Bundle bundle = new();

        bundle.Add(new Cupcake());

        Assert.Equal(1, bundle.GetPrice());
        Assert.Equal("📦 contains 🧁", bundle.ToString());
    }

    [Fact]
    public void We_Can_Build_A_Bundle_With_One_Cupcake_And_One_Cookie_And_Check_Price_Or_Description()
    {
        Bundle bundle = new();

        bundle.Add(new Cupcake());
        bundle.Add(new Cookie());

        Assert.Equal(3, bundle.GetPrice());
        Assert.Equal("📦 contains 🧁 and 🍪", bundle.ToString());
    }

    [Fact]
    public void We_Can_Build_A_Bundle_With_Two_Cupcake_And_One_Cookie_And_Check_Price_Or_Description()
    {
        Bundle bundle = new();

        bundle.Add(new Cupcake(new Chocolate()));
        bundle.Add(new Cupcake(new Peanut()));
        
        bundle.Add(new Cookie());

        Assert.Equal((decimal)4.3, bundle.GetPrice());
        Assert.Equal("📦 contains 🧁 with 🍫 and 🧁 with 🥜 and 🍪", bundle.ToString());
    }

    [Fact]
    public void We_Can_Build_A_Bundle_Containing_Two_Bundles_One_Three_Cookies_One_With_Three_Cupcakes()
    {
        Bundle bundle = new();

        Bundle bundleCookie = new Bundle();
        Bundle bundleCupcake = new Bundle();

        bundleCookie.Add(new Cookie(), new Cookie(), new Cookie());
        bundleCupcake.Add(new Cupcake(), new Cupcake(), new Cupcake());

        bundle.Add(bundleCookie, bundleCupcake);

        Assert.Equal((decimal)9, bundle.GetPrice());
        Assert.Equal("📦 contains 📦📦 one with 🍪🍪🍪 one with 🧁🧁🧁", bundle.ToString());
    }
}

//We can build a Bundle with 1 Cupcake and check price or description
//We can build a Bundle with 1 Cupcake and 1 Cookie and check price or description
//We can build a Bundle with 2 Cupcake and 1 Cookie and check price or description
//We can build a bundle with 1 bundle of 2 cakes and 1 Cupcake and check price or description
//We can build a bundle with many bundle of bundle and many cakes and check price or description