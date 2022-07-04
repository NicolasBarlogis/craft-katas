using Order_Shipping.Domain;

namespace OrderShipping.Domain
{
    public class OrderItem
    {
        public Product Product { get; set; }
        public Quantity Quantity { get; set; }
        public decimal TaxedAmount { get; set; }
        public decimal Tax { get; set; }

        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = new Quantity(quantity);
            TaxedAmount = Round(Product.Taxed() * Quantity.Value);
            Tax = Round(Product.Tax() * Quantity.Value);
        }

        private static decimal Round(decimal amount)
        {
            return decimal.Round(amount, 2, MidpointRounding.ToPositiveInfinity);
        }
    }
}