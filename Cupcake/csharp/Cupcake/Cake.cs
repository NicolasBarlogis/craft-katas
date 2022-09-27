namespace Cupcakes;
public abstract class Cake : IPackable
{
    protected readonly Topping? Topping;

    protected abstract string Logo { get; }
    protected abstract decimal Price { get; }
    
    protected Cake(Topping? topping = null)
    {
        Topping = topping;
    }

    public override string ToString()
    {
        return Topping is null ? Logo : Logo + " with " + Topping;
    }

    public decimal GetPrice()
    {
        return Topping is null ? Price : Price + Topping.GetPrice();
    }
}
