namespace Cupcakes
{
    public abstract class CakeTopping : CakeComponent
    {
        private readonly ICakeComponent? _lowerLayer;

        public override double GetPrice()
        {
            return (_lowerLayer == null) ? Price : _lowerLayer.GetPrice() + Price;
        }

        protected CakeTopping(ICakeComponent? lowerLayer)
        {
            _lowerLayer = lowerLayer;
        }

        public override string ToString()
        {
            var baseStr = (_lowerLayer == null)?"":_lowerLayer.ToString();
            return baseStr + ((baseStr.Length > 2)?" and ":" with ")+Component;
        }
    }
}