namespace Cupcakes;

public class Cupcake : Cake
{
    public Cupcake(Topping? topping = null) : base(topping)
    {
        
    }

    protected override string Logo => "🧁";
    protected override decimal Price => 1;

    //public override decimal GetPrice() => (decimal)(Topping is not null ? 1.1 : 1.0);
}
