namespace Cupcakes;

public class Peanut : Topping
{
    public Peanut(Topping? topping = null) : base(topping)
    {
    }

    protected override string Logo => "🥜";
}