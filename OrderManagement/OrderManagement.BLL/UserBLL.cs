using OrderManagement.IDAL;
using OrderManagement.Model;
using OrderManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.BLL
{
    public class UserBLL
    {
        private readonly IUserDAL _userDal;

        public UserBLL(IUserDAL userDal)
        {
            _userDal = userDal;
        }

        public List<User> GetUserList()
        {
            return _userDal.GetUserList();
        }

        public User GetUser(int userNo)
        {
            if (userNo <= 0) throw new ArgumentException();
            return _userDal.GetUser(userNo);
        }

        public bool Signup(User user)
        {
            if (user == null) throw new ArgumentNullException();
            return _userDal.Signup(user);
        }

        public bool UpdateUser(User user)
        {
            if (user == null) throw new ArgumentNullException();
            return _userDal.UpdateUser(user);
        }

        public bool DeleteUser(int userNo)
        {
            if (userNo <= 0) throw new ArgumentException();
            return _userDal.DeleteUser(userNo);
        }

        public bool Signin(SigninViewModel signinModel)
        {
            return _userDal.Signin(signinModel);
        }
    }
}
