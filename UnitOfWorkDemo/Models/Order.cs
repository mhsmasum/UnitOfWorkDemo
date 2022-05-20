using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UnitOfWorkDemo.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public decimal OrderAmount { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
