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
        
        public int ProductId { get; set; }
        
        public int Quantity{get;set;} 

        public DateTime OrderPlaced { get; set; }
        //public int amount { get; set; }
       
    }
}
