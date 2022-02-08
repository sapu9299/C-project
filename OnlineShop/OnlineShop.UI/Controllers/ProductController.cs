using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using OnlineShop.Entity.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.UI.Controllers
{
    public class ProductController : Controller
    {
        private IConfiguration _configuration;
        public ProductController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Product> productresult = null;
            using (HttpClient client = new HttpClient())
            {
                string endPoint = _configuration["WebApiBaseUrl"] + "Product/GetProducts";
                using (var response = await client.GetAsync(endPoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        productresult = JsonConvert.DeserializeObject<IEnumerable<Product>>(result);
                    }
                }
            }
            return View(productresult);
        }
        public IActionResult ProductEntry()
        
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ProductEntry(Product product)
        {
            ViewBag.status = "";
            if (Request.Form.Files.Count > 0)
            {
                MemoryStream ms = new MemoryStream();
                Request.Form.Files[0].CopyTo(ms);
                product.ImgPoster = ms.ToArray();
            }
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8, "application/json");
                string endPoint = _configuration["WebApiBaseUrl"] + "Product/AddProduct";
                using (var response = await client.PostAsync(endPoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "Product details saved successfully!";
                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "Wrong entries!";
                    }
                }
            }
            return View();
        }
        public async Task<IActionResult> Details(int ProductId)
        {
            Product productresult = null;
            using (HttpClient client = new HttpClient())
            {     
                string endPoint = _configuration["WebApiBaseUrl"] + "Product/Details?ProductId="+ProductId;
                using (var response = await client.GetAsync(endPoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        productresult = JsonConvert.DeserializeObject<Product>(result);
                    }
                }
            }
        return View(productresult);
        }
        

        public async Task<IActionResult> Data(int CategoryId)
        {
             IEnumerable <Product> categoryresult = null;
            using (HttpClient client = new HttpClient())
            {
                string endPoint = _configuration["WebApiBaseUrl"] + "Product/Data?CategoryId=" + CategoryId;
                using (var response = await client.GetAsync(endPoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        categoryresult = JsonConvert.DeserializeObject<IEnumerable<Product>>(result);
                    }
                }
            }
            return View(categoryresult);
        }
    }
}
