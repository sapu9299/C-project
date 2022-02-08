using OnlineShop.DAL.Repository;
using OnlineShop.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.BAL.Services
{
  public  class CartService
    {
        IShoppingRepository _shoppingRepository;
       public  void AddToCart(int ProductId)
        {
            _shoppingRepository.AddToCart(ProductId);
        }

       public  void DeleteItem(int ProductId)
        {
            _shoppingRepository.DeleteItem(ProductId);
        }
        public IEnumerable<ShoppingCart> GetShoppingCarts()
        {
            return _shoppingRepository.GetShoppingCarts();
        }
    }
}
