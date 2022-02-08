using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineShop.Entity.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int ShoppingCartItemId { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
        //public ShoppingCart shoppingcart { get; set; }
        //[ForeignKey("shoppingcart")]
        public int ShoppingCartId { get; set; }
    }
}
