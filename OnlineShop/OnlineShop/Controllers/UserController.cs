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
    public class UserController : ControllerBase
    {
        private UserInfoService _userInfoService;
        public UserController(UserInfoService userInfoService)
        {
            _userInfoService = userInfoService;
        }
        [HttpPost("Register")]
        public IActionResult Register([FromBody] UserInfo userInfo)
        {
            _userInfoService.Register(userInfo);
            return Ok("Register successfully!!");
        }
        [HttpPost("Login")]
        public IActionResult Login([FromBody] UserInfo userInfo)
        {
            var result= _userInfoService.Login(userInfo);
            if (result != null)
                return Ok(result);
            else
                return NotFound();
        }
        
    }
}
