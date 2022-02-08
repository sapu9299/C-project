using OnlineShop.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.DAL.Repository
{
   public interface IProductRepository
    {
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void  Delete(int ProductId);
        Product GetProductById(int ProductId);
        IEnumerable<Product> GetProducts();
        Product  Details(int ProductId);
        IEnumerable<Product> Data(int CategoryId);
        Product Order(int ProductId);

    }
}
