namespace OrderShipping.Domain
{
    public class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal TaxedAmount { get; set; }
        public decimal Tax { get; set; }

        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public decimal Taxed()
        {
            return Round(Product.Taxed() * Quantity);
        }

        private static decimal Round(decimal amount)
        {
            return decimal.Round(amount, 2, MidpointRounding.ToPositiveInfinity);
        }
    }
}