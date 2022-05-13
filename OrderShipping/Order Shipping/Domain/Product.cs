namespace OrderShipping.Domain
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }

        public decimal GetUnitaryTax()
        {
            return Round((Price / 100m) * Category.TaxPercentage);
        }

        public decimal GetUnitaryTaxedAmount()
        {
            return Round(Price + GetUnitaryTax());
        }

        private static decimal Round(decimal amount)
        {
            return decimal.Round(amount, 2, System.MidpointRounding.ToPositiveInfinity);
        }
    }
}