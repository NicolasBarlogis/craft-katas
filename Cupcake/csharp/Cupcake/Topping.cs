namespace Cupcakes;

public abstract class Topping
{
    protected abstract string Logo { get; }


    public override string ToString()
    {
        return Logo;
    }
}