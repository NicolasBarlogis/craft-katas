namespace Cupcakes;

public class Cookie : Cake
{
    public Cookie(Chocolate? chocolate = null) : base(chocolate)
    {

    }

    protected override string Logo => "🍪";
    
}
