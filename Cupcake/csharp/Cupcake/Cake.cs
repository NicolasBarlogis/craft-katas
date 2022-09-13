namespace Cupcakes;
public abstract class Cake
{
    protected readonly Topping? Topping;

    protected abstract string Logo { get; }
    
    protected Cake(Topping? topping = null)
    {
        Topping = topping;
    }

    public override string ToString()
    {
        return Topping is null ? Logo : Logo + " with " + Topping;
    }

    public abstract decimal GetPrice();
}
