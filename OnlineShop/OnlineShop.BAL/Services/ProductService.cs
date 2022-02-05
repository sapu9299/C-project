using OnlineShop.DAL.Repository;
using OnlineShop.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.BAL.Services
{
    public class ProductService
    {
        IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void AddProduct(Product product)
        {
            _productRepository.AddProduct(product);
        }
      
        public void UpdateProduct(Product product)
        {
            _productRepository.UpdateProduct(product);
        }
        
        public void DeleteProduct(int productId)
        {
            _productRepository.DeleteProduct(productId);
        }
        public void GetProductById(int ProductId)
        {
            _productRepository.GetProductById(ProductId);
        }
        public IEnumerable<Product> GetProducts()
        {
            return _productRepository.GetProducts();
        }


    }
}
