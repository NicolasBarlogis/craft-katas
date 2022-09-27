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
}

public sealed class Bundle
{
    private Cupcake? _cupcake;

    public void Add(Cupcake cupcake)
    {
        _cupcake = cupcake;
    }

    public decimal GetPrice()
    {
        return _cupcake?.GetPrice() ?? 0;
    }

    public override string ToString()
    {
        return _cupcake is not null ? "📦 contains " + _cupcake : "empty 📦";
    }
}

//We can build a Bundle with 1 Cupcake and check price or description
//We can build a Bundle with 1 Cupcake and 1 Cookie and check price or description
//We can build a Bundle with 2 Cupcake and 1 Cookie and check price or description
//We can build a bundle with 1 bundle of 2 cakes and 1 Cupcake and check price or description
//We can build a bundle with many bundle of bundle and many cakes and check price or description