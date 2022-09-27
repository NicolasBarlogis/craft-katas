using System.Collections.Generic;
using System.Linq;
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
}

public sealed class Bundle
{
    private readonly List<IPackable> _items = new ();

    public void Add(IPackable item)
    {
        _items.Add(item);
    }

    public decimal GetPrice()
    {
        return _items.Sum(item => item.GetPrice());
    }

    public override string ToString()
    {
        if (!_items.Any())
        {
            return "empty 📦";
        }

        var bundleMessage = "📦 contains " + _items[0];
        for (var i = 1; i < _items.Count; i++)
        {
            bundleMessage += " and " + _items[i];
        }

        return bundleMessage;
    }
}

//We can build a Bundle with 1 Cupcake and check price or description
//We can build a Bundle with 1 Cupcake and 1 Cookie and check price or description
//We can build a Bundle with 2 Cupcake and 1 Cookie and check price or description
//We can build a bundle with 1 bundle of 2 cakes and 1 Cupcake and check price or description
//We can build a bundle with many bundle of bundle and many cakes and check price or description