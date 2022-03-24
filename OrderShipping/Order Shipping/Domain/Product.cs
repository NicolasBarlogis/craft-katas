namespace OrderShipping.Domain
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }

        public decimal ComputeUnitaryTaxedAmount()
        {
            return Round(Price + ComputeUnitaryTax());
        }

        public decimal ComputeUnitaryTax()
        {
            return Round(Price / 100m * Category.TaxPercentage);
        }

        private static decimal Round(decimal amount)
        {
            return decimal.Round(amount, 2, System.MidpointRounding.ToPositiveInfinity);
        }
    }
}