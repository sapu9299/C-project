using OnlineShop.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.DAL.Repository
{
    public interface IShoppingCart
    {
        void AddToCart();
        void UpdateProduct(Product product);
        void DeleteProduct(int ProductId);
    }
}
