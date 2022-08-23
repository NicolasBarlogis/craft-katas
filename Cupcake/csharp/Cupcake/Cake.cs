namespace Cupcakes;
public abstract class Cake
{
    protected readonly Chocolate? Chocolate;

    protected abstract string Logo { get; }

    protected Cake(Chocolate? chocolate = null)
    {
        Chocolate = chocolate;
    }

    public override string ToString()
    {
        return Chocolate is null ? Logo : Logo + " with 🍫";
    }
}
