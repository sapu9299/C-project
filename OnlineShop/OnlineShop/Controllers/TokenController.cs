﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using OnlineShop.DAL.Data;
using OnlineShop.Entity.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppCoreApi.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        public IConfiguration _configuration;
        private readonly ProductDbContext _context;

        public TokenController(IConfiguration config, ProductDbContext context)
        {
            _configuration = config;
            _context = context;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Post(UserInfo _userData)
        {

            if (_userData != null && _userData.Email != null && _userData.Password != null)
            {
                var user = await GetUser(_userData);

                if (user != null)
                {
                    
                    var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim("Id", user.UserId.ToString()),
                        new Claim("FirstName", user.Firstname),
                        new Claim("LastName", user.Lastname),
                        new Claim("Email", user.Email),
                       };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], claims, expires: DateTime.UtcNow.AddDays(1), signingCredentials: signIn);

                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                }
                else
                {
                    return BadRequest("Invalid credentials");
                }
            }
            else
            {
                return BadRequest();
            }
        }
        
        private async Task<UserInfo> GetUser([FromBody]UserInfo user)
        {
            UserInfo userInfo = null;
            var result = _context.userInfo.Where(u => u.Email == user.Email && u.Password == user.Password);
            foreach (var item in result)
            {
                userInfo = new UserInfo();
                userInfo.UserId = item.UserId;
                userInfo.Firstname = item.Firstname;
                userInfo.Lastname = item.Lastname;
                userInfo.Email = item.Email;
                userInfo.Mobile = item.Mobile;
            }
            return userInfo;

        }
    }
}
