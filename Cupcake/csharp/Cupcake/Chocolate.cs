namespace Cupcakes;

public class Chocolate : Topping
{
    public Chocolate(Topping? topping = null) : base(topping)
    {
    }

    protected override string Logo => "🍫";
}