namespace Cupcakes;

public class Cupcake : Cake
{
    public Cupcake(Topping? topping = null) : base(topping)
    {
        
    }

    protected override string Logo => "🧁";

    protected override decimal Price => 1;
}
