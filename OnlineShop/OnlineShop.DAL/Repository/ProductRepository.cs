using Microsoft.EntityFrameworkCore;
using OnlineShop.DAL.Data;
using OnlineShop.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.DAL.Repository
{
   public class ProductRepository:IProductRepository
    {
        ProductDbContext _productDbContext;
        public ProductRepository(ProductDbContext productDbContext)
        {
            _productDbContext = productDbContext;
        }

        public void AddProduct(Product product)
        {
            _productDbContext.Products.Add(product);
            _productDbContext.SaveChanges();
            
        }
        public void UpdateProduct(Product product)
        {
            _productDbContext.Entry(product).State = EntityState.Modified;
            _productDbContext.SaveChanges();
        }
        public Product GetProductById(int ProductId)
        {
            return _productDbContext.Products.Find(ProductId);
        }
       

        public IEnumerable<Product> GetProducts()
        {
            return _productDbContext.Products.ToList();
        }

        public void Delete(int ProductId)
        {
            var product = _productDbContext.Products.Find(ProductId);
            _productDbContext.Products.Remove(product);
            _productDbContext.SaveChanges();
        }

        public Product Details(int ProductId)
        {
          return _productDbContext.Products.Find(ProductId);

        }
        public IEnumerable<Product> Data(int CategoryId)
        {
            return _productDbContext.Products.Where(p=>p.CategoryId==CategoryId).ToList();

        }

        public Product CreateOrder(int ProductId)
        {
            return _productDbContext.Products.Find(ProductId);

        }

        public Product Order(int ProductId)
        {
            throw new NotImplementedException();
        }

        //public Product Order(int ProductId)
        //{

        //}
    }
}
