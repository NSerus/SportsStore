using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class EntityFrameWorkRepository : ISportsStoreRepository
    {
        private SportsStoreDbContext context;
        public EntityFrameWorkRepository(SportsStoreDbContext context){
            this.context = context;            
        }

        public IEnumerable<Product> Products=> context.Products;
    }
}
