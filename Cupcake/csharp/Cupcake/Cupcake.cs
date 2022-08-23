namespace Cupcakes;

public class Cupcake
{
    private readonly Chocolate? _chocolate;

    public Cupcake(Chocolate? chocolate = null)
    {
        _chocolate = chocolate;
    }

    public override string ToString()
    {
        return _chocolate is null ? "🧁" : "🧁 with 🍫";
    }
}
