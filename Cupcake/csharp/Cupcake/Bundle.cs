namespace Cupcakes;

public sealed class Bundle
{
    private readonly List<IPackable> _items = new ();

    public void Add(IPackable item)
    {
        _items.Add(item);
    }

    public decimal GetPrice()
    {
        return _items.Sum(item => item.GetPrice());
    }

    public override string ToString()
    {
        if (!_items.Any())
        {
            return "empty 📦";
        }

        var bundleMessage = "📦 contains " + _items[0];
        for (var i = 1; i < _items.Count; i++)
        {
            bundleMessage += " and " + _items[i];
        }

        return bundleMessage;
    }

    public void Add(Cookie item, Cookie cookie, Cookie cookie1)
    {
        throw new NotImplementedException();
    }

    public void Add(Cupcake item, Cupcake cookie, Cupcake cookie1)
    {
        throw new NotImplementedException();
    }

    public void Add(Bundle bundleCookie, Bundle bundleCupcake)
    {
        throw new NotImplementedException();
    }
}