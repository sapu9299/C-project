using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineShop.Entity.Models
{
    public class ShoppingCart
    {

        [Key]
        public int CardId { get; set; }
        public string ShoppingCartId { get; set; }

        public List<Order> order { get; set; }
    }
}
