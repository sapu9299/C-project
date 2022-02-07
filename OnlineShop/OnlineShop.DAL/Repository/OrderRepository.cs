using Microsoft.EntityFrameworkCore;
using OnlineShop.DAL.Data;
using OnlineShop.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.DAL.Repository
{
    public class OrderRepository : IOrderRepository
    {
        ProductDbContext _productDbContext;
        //ShoppingCart _shoppingCart;

        public OrderRepository(ProductDbContext productDbContext)
        {
            _productDbContext = productDbContext;

        }

        //    public void CreateOrder(Order order)
        //    {
        //        order.OrderPlaced = DateTime.Now;

        //        _productDbContext.Orders.Add(order);

        //        //var shoppingCartItems = _shoppingCart.ShoppingCartItems;

        //        foreach (var shoppingCartItem in shoppingCartItems)
        //        {
        //            var orderDetail = new OrderDetail()
        //            {
        //                Amount = shoppingCartItem.Amount,
        //                ProductId = shoppingCartItem.Product.ProductId,
        //                OrderId = order.OrderId,
        //                Price = shoppingCartItem.Product.Cost
        //            };

        //            _productDbContext.OrderItems.Add(orderDetail);
        //        }

        //        _productDbContext.SaveChanges();
        //    }
        //}

        //public void AddOrder(Order order)
        //{
        //    _productDbContext.Orders.Add(order);
        //    _productDbContext.SaveChanges();
        //}

        //public Order GetOrderById(int OrderId)
        //{
        //    return _productDbContext.Orders.Find(OrderId);
        //}
    }
}

