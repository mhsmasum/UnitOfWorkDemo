using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitOfWorkDemo.Models
{
    public class Product
    {
        [key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Decimal Price { get; set; }
    }
}
