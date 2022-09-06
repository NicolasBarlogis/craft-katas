namespace Cupcakes;

public class Chocolate : Topping
{
    private readonly Peanut? _peanut;
    
    public Chocolate(Peanut peanut)
    {
        _peanut = peanut;
    }

    public Chocolate()
    {
    }

    protected override string Logo => _peanut is null ? "🍫" : "🍫 and " + _peanut;
}