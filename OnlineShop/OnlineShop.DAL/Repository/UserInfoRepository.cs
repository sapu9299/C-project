using OnlineShop.DAL.Data;
using OnlineShop.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.DAL.Repository
{
    public class UserInfoRepository:IUserInfoRepository
    {
       private ProductDbContext _productDbContext;
        public UserInfoRepository(ProductDbContext productDbContext)
        {
            _productDbContext = productDbContext;
        }
        public UserInfo Login(UserInfo user)
        {
            UserInfo userInfo = null;
            var result = _productDbContext.userInfo.Where(obj => obj.Email == user.Email && obj.Password == user.Password).ToList();
            if(result.Count>0)
            {
                userInfo = result[0];
            }
            return userInfo;
        }

        public void Register(UserInfo userInfo)
        {
            _productDbContext.userInfo.Add(userInfo);
            _productDbContext.SaveChanges();
        }

       
    }
}
