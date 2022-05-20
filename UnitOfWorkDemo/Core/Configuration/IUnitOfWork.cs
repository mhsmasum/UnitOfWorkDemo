using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitOfWorkDemo.Core.Repository;

namespace UnitOfWorkDemo.Core.Configuration
{
   public interface IUnitOfWork
    {
        IProductRepository Products { get; }
        IOrderRepository Orders { get; }

        Task CompleteAsync();
    }
}
