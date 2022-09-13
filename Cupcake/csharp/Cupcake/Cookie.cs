namespace Cupcakes;

public class Cookie : Cake
{
    public Cookie(Topping? topping = null) : base(topping)
    {

    }

    protected override string Logo => "🍪";

    protected override decimal Price => 2;
}
