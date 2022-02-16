namespace Cupcakes
{
    public class Peanut : CakeTopping
    {
        protected override double Price => 0.2;
        protected override string Component => "🥜";

        public Peanut(ICakeComponent? lowerLayer) : base(lowerLayer)
        {
        }
    }
}