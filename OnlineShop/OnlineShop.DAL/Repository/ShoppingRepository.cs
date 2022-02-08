using OnlineShop.DAL.Data;
using OnlineShop.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.DAL.Repository
{
   public class ShoppingRepository:IShoppingRepository
    {
        ProductDbContext _productDbContext;
        public ShoppingRepository(ProductDbContext productDbContext)
        {
            _productDbContext = productDbContext;
        }
        

        public void AddToCart(int ProductId)
        {
            _productDbContext.ShoppingCarts.Find(ProductId);
        }

        public void DeleteItem(int ProductId)
        {
            var carts = _productDbContext.ShoppingCarts.Find(ProductId);
            _productDbContext.ShoppingCarts.Remove(carts);
            _productDbContext.SaveChanges();
        }

        public IEnumerable<ShoppingCart> GetShoppingCarts()
        {
            return _productDbContext.ShoppingCarts.ToList();
        }
    }
}
