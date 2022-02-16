using Bundle;

namespace Cupcakes
{
    public abstract class CakeComponent : ICakeComponent, IBundlelisable
    {
        protected abstract double Price { get; }
        protected abstract string Component { get; }

        public virtual double GetPrice()
        {
            return Price;
        }
        public override string ToString()
        {
            return Component;
        }
    }
}