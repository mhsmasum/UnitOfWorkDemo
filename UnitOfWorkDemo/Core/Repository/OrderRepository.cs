using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitOfWorkDemo.Data;
using UnitOfWorkDemo.Models;

namespace UnitOfWorkDemo.Core.Repository
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        
        public OrderRepository(ApplicationDBContext context , ILogger logger) : base (context , logger)
        {
          
        }
    }
}
