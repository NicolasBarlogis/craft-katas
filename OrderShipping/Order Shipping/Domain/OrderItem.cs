namespace OrderShipping.Domain
{
    public class OrderItem
    {
        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;

            TaxedAmount = Round(product.ComputeUnitaryTaxedAmount() * quantity);
            Tax = Round(product.ComputeUnitaryTax() * quantity);
        }

        private static decimal Round(decimal amount)
        {
            return decimal.Round(amount, 2, System.MidpointRounding.ToPositiveInfinity);
        }

        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal TaxedAmount { get; set; }
        public decimal Tax { get; set; }
    }
}