namespace Cupcakes;

public class Peanut : Topping
{
    public Peanut()
    {
    }

    public Peanut(Chocolate chocolate)
    {
        throw new NotImplementedException();
    }

    protected override string Logo => "🥜";
}