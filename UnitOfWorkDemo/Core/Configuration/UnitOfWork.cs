using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitOfWorkDemo.Core.Repository;
using UnitOfWorkDemo.Data;

namespace UnitOfWorkDemo.Core.Configuration
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDBContext _context;
        private readonly ILogger _logger;

        public IProductRepository Products { get; private set; }
        public IOrderRepository Orders { get; private set; }

    

        public UnitOfWork(
            ApplicationDBContext context,
            ILoggerFactory loggerFactory
        )
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("logs");

            Products = new ProductReposituory(_context, _logger);
            Orders = new OrderRepository(_context, _logger);
        }

        public async Task CompleteAsync()
        {
            try
            {
                var data = await _context.SaveChangesAsync();
            }
            catch (Exception aa)
            {
                var messge = aa.ToString();
                throw;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
