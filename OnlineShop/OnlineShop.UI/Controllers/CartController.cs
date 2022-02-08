using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using OnlineShop.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.UI.Controllers
{
    public class CartController : Controller
    {
        private IConfiguration _configuration;
        public CartController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<ShoppingCart> cartresult = null;
            using (HttpClient client = new HttpClient())
            {
                string endPoint = _configuration["WebApiBaseUrl"] + "Cart/GetShoppingCarts";
                using (var response = await client.GetAsync(endPoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        cartresult = JsonConvert.DeserializeObject<IEnumerable<ShoppingCart>>(result);
                    }
                }
            }
            return View(cartresult);
        }
        public async Task<IActionResult> AddToCart(int ProductId)
        {
            Product cartresult = null;
            using (HttpClient client = new HttpClient())
            {
                string endPoint = _configuration["WebApiBaseUrl"] + "Product/AddToCart?ProductId=" + ProductId;
                using (var response = await client.GetAsync(endPoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        cartresult = JsonConvert.DeserializeObject<Product>(result);
                    }
                }
            }
            return View(cartresult);
        }
        
     
    }
}
