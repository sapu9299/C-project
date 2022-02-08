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

        public void Delete(int productId)
        {
            _productRepository.Delete(productId);
        }

        public void GetProductById(int ProductId)
        {
            _productRepository.GetProductById(ProductId);
        }
        public IEnumerable<Product> GetProducts()
        {
            return _productRepository.GetProducts();
        }
        public Product Details(int ProductId)
        {
          return  _productRepository.Details(ProductId);
        }
        public IEnumerable<Product> Data(int CategoryId)
        {
            return _productRepository.Data(CategoryId);
        }


    }
}
