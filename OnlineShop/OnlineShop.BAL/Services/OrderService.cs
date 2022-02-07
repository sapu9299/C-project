using OnlineShop.DAL.Repository;
using OnlineShop.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.BAL.Services
{
   public class OrderService
    {
        IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        //public void CreateOrder(Order order)
        //{
        //    _orderRepository.CreateOrder(order);
        //}


        //public void AddOrder(Order order)
        //{
        //    _orderRepository.AddOrder(order);
        //}

        //public void GetOrderById(int OrderId)
        //{
        //    _orderRepository.GetOrderById(OrderId);
        //}


    }
}
