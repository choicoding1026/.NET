using OrderManagement.Model;
using OrderManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.IDAL
{
    public interface IUserDAL
    {
        List<User> GetUserList();

        User GetUser(int userNo);

        bool Signup(User user);

        bool UpdateUser(User user);

        bool DeleteUser(int userNo);

        bool Signin(SigninViewModel signinModel);
    }
}
