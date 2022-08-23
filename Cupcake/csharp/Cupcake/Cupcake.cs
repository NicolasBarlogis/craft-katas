namespace Cupcakes;

public class Cupcake : Cake
{
    public Cupcake(Chocolate? chocolate = null) : base(chocolate)
    {
        
    }

    protected override string Logo => "🧁";
}
