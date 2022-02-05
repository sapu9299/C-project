using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineShop.Entity.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        //public Order order { get; set; }
        //[ForeignKey("order")]
        public int OrderId { get; set; }
        //public Product product { get; set; }
        //[ForeignKey("product")]
        public int ProductId { get; set; }
        public int Amount { get; set; }
        
        
        public decimal Price { get; set; }
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }

    }
}
