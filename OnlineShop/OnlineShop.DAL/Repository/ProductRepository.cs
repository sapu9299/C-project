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
            var movie = _productDbContext.Products.Find(ProductId);
            _productDbContext.Products.Remove(movie);
            _productDbContext.SaveChanges();
        }

        public void Details(int ProductId)
        {
            _productDbContext.Products.Find(ProductId);
            _productDbContext.SaveChanges();

        }
    }
}
