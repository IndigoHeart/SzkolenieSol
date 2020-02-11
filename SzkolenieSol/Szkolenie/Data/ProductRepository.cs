using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Szkolenie.Models;

namespace Szkolenie.Data
{
    public class ProductRepository : RepositoryBase<Product>
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
