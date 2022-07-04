using Order_Shipping.Domain.Exception;

namespace Order_Shipping.Domain
{
    public record Quantity
    {
        public int Value { get; }

        public Quantity(int quantity)
        {
            if (quantity < 0)
            {
                throw new QuantityCantBeNegativeException();
            }

            Value = quantity;
        }
    }
}