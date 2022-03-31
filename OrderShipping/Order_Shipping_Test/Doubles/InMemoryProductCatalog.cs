using System.Collections.Generic;
using System.Linq;
using OrderShipping.Domain;
using OrderShipping.Repository;
using OrderShipping.UseCase;

namespace OrderShippingTest.Doubles
{
    public class InMemoryProductCatalog : IProductCatalog
    {
        private readonly IList<Product> _products;

        public InMemoryProductCatalog(IList<Product> products)
        {
            _products = products;
        }

        public Product GetByName(string name)
        {
            var product = _products.FirstOrDefault(p => p.Name == name);
            if (product == null)
            {
                throw new UnknownProductException();
            }

            return product;
        }
    }
}