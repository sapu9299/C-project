using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.BAL.Services;
using OnlineShop.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProductService _productService;
        public ProductController(ProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("GetProducts")]
        public IEnumerable<Product> GetProducts()
        {
           
            return _productService.GetProducts();
        }
        [HttpPost("AddProduct")]
        public IActionResult AddProduct([FromBody] Product product)
        {
            _productService.AddProduct(product);
            return Ok("Product created successfully!!");
        }
        [HttpPost("DeleteProduct")]
        public IActionResult Delete(int ProductId)
        {
            _productService.Delete(ProductId);
            return Ok("Product deleted successfully!!");
        }
        [HttpGet("Details")]
        public Product Details(int ProductId)
        {          
            return _productService.Details(ProductId);
        }



        [HttpPut("UpdateProduct")]
        public IActionResult UpdateProduct([FromBody] Product product)
        {
            _productService.UpdateProduct(product);
            return Ok("Product updated successfully!!");
        }
        [HttpGet("Data")]
        public IEnumerable<Product> Data(int CategoryId)
        {
            return _productService.Data(CategoryId);
        }
    }
}

