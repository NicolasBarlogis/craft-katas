namespace Cupcakes;

public abstract class Topping
{
    private readonly Topping? _nextTopping;

    protected abstract string Logo { get; }

    protected abstract decimal Price { get; }

    protected Topping(Topping? nextTopping = null)
    {
        _nextTopping = nextTopping;
    }

    public override string ToString()
    {
        return _nextTopping is null ? Logo : Logo + " and " + _nextTopping;
    }

    public decimal GetPrice()
    {
        return _nextTopping is not null ? Price + _nextTopping.GetPrice() : Price;
    }
}