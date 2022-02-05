using OnlineShop.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.DAL.Repository
{
   public  interface IUserInfoRepository
    {
        void Register(UserInfo userinfo);
        UserInfo Login(UserInfo user);
    }
}
