using OnlineShop.DAL.Repository;
using OnlineShop.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.BAL.Services
{
   public class UserInfoService
    {
        IUserInfoRepository _userInfoRepository;
        public UserInfoService(IUserInfoRepository userInfoRepository)
        {
            _userInfoRepository = userInfoRepository;
        }
        public UserInfo Login(UserInfo user)
        {
            return _userInfoRepository.Login(user);
        }

        public void Register(UserInfo userInfo)
        {
            _userInfoRepository.Register(userInfo);
        }
    }
}
