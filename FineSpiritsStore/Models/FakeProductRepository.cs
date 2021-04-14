using System.Collections.Generic;
using System.Linq;

namespace FineSpiritsStore.Models
{

        public class FakeProductRepository /* : IProductRepository */
        {
            public IQueryable<Product> Products => new List<Product> {
            new Product { Name = "Bombay Sapphire London Dry Gin", Price = 25.99M },
            new Product { Name = "Crystal Head Vodka", Price = 59.99M },
            new Product { Name = "Antigua Porteno 15 Yr Rum", Price = 49.99M }
    }.AsQueryable<Product>();

    }
}