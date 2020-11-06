using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class FakeRepository : ISportsStoreRepository
    {
        public IEnumerable<Product> Products => new List<Product>
        {
            new Product {ProductId = 1,
                Name = "Soccar Ball",
                Price = 25,
                Category = "Soccer" },
            new Product {ProductId = 2,
                 Name = "Surf Board",
                 Price = 302,
                 Category = "Aquatic sports"  },
            new Product {ProductId = 3,
                 Name = "Running Shoes",
                 Price = 95,
                 Category = "Running"  }
        };
    }
}
