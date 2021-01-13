using System;
using System.Collections.Generic;
using WebService.IDAL;
using WebService.Model;

namespace WebService.BLL
{
    public class UserBLL 
    {
        private readonly IUserDAL _userDal;

        public UserBLL(IUserDAL userDal)
        {
            _userDal = userDal;
        }

        public User GetUser(int userNo)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUserList()
        {
            throw new NotImplementedException();
        }
    }
}

