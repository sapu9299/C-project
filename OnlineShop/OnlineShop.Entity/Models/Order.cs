using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineShop.Entity.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        
       productId
            userId
            quantity
            amount
        public DateTime OrderPlaced { get; set; }
    }
}
