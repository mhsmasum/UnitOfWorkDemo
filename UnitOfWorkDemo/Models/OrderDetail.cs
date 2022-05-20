﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UnitOfWorkDemo.Models
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set;}
        public int OrderId { get; set; }
        
        public  Order Order { get; set; }
        public int ProductId { get; set; }
     
        [NotMapped]
        public   Product Product { get; set; }
      
    }
}
