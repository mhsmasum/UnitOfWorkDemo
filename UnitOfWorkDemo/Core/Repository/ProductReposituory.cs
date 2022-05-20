using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitOfWorkDemo.Data;
using UnitOfWorkDemo.Models;

namespace UnitOfWorkDemo.Core.Repository
{
    public class ProductReposituory : GenericRepository<Product>, IProductRepository
    {
       
        public ProductReposituory(ApplicationDBContext context,
            ILogger logger) : base(context, logger)
        {

        }

        public override async Task<IEnumerable<Product>> All()
        {
            try
            {
                return await dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} All method error", typeof(ProductReposituory));
                return new List<Product>();
            }
        }
       

    }
}
