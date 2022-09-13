namespace Cupcakes;

public class Cookie : Cake
{
    public Cookie(Topping? topping = null) : base(topping)
    {

    }

    protected override string Logo => "🍪";

    public int GetPrice()
    {
        return 1;
    }
}
