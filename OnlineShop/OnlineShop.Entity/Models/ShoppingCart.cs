using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineShop.Entity.Models
{
    public class ShoppingCart
    {

        [Key]
       
        public int ShoppingCartId { get; set; }

        public int UserId { get; set; }
        //public int ProductId { get; set; }

        //public List<Product> products { get; set; }
        public int Cost { get; set; }
        //public virtual Product product { get; set; }

        
    }
}
