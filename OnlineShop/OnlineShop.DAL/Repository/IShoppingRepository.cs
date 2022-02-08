using OnlineShop.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.DAL.Repository
{
    public interface IShoppingRepository
    {
        void AddToCart(int ProductId);
        
        void DeleteItem(int ProductId);
        IEnumerable<ShoppingCart> GetShoppingCarts();
    }
}
