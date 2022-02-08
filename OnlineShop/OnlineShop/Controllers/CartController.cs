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
    public class CartController : ControllerBase
    {
        private CartService _cartService;
        public CartController(CartService cartService)
        {
            _cartService = cartService;
        }
       
        [HttpPost("AddToCart")]
        public IActionResult AddToCart( int ProductId)
        {
            _cartService.AddToCart(ProductId);
            return Ok(" ");
        }
        [HttpPost("DeleteItem")]
        public IActionResult DeleteItem(int ProductId)
        {
            _cartService.DeleteItem(ProductId);
            return Ok(" Remove successfully!!");
        }
        [HttpGet("GetShoppingCarts")]
        public IEnumerable<ShoppingCart> GetShoppingCarts()
        {

            return _cartService.GetShoppingCarts();
        }
    }
}

    

