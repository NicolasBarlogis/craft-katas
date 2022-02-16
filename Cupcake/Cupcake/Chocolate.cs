namespace Cupcakes
{
    public class Chocolate : CakeTopping
    {
        protected override double Price => 0.1;
        protected override string Component => "🍫";

        public Chocolate(ICakeComponent? lowerLayer) : base(lowerLayer)
        {
        }
    }
}