using OnlineShop.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.DAL.Repository
{
   public interface IOrderRepository
    {
        void CreateOrder(Order order);
        //void AddOrder(Order order);
        //Order GetOrderById(int OrderId);
    }
}
