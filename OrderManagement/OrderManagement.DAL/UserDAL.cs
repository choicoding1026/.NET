using Microsoft.Extensions.Configuration;
using OrderManagement.DAL.DataContext;
using OrderManagement.IDAL;
using OrderManagement.Model;
using OrderManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderManagement.DAL
{
    public class UserDAL : IUserDAL
    {
        private readonly IConfiguration _configuraton;

        public UserDAL(IConfiguration configuration)
        {
            _configuraton = configuration;
        }

        public List<User> GetUserList()
        {
            using (var db = new OrderManagementDbContext(_configuraton))
            {
                return db.Users
                    .OrderByDescending(n => n.UserNo)
                    .ToList();
            }
        }

        public User GetUser(int userNo)
        {
            using (var db = new OrderManagementDbContext(_configuraton))
            {
                return db.Users
                    .FirstOrDefault(n => n.UserNo.Equals(userNo));
            }
        }

        public bool Signup(User user)
        {
            using (var db= new OrderManagementDbContext(_configuraton))
            {
                db.Users.Add(user);
                return true;
            }
        }

        public bool UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(int userNo)
        {
            throw new NotImplementedException();
        }

        public bool Signin(SigninViewModel signinModel)
        {
            using (var db = new OrderManagementDbContext(_configuraton))
            {
                var user = db.Users.FirstOrDefault(u=> u.UserID.Equals(signinModel.UserID) && u.UserPW.Equals(signinModel.UserPW));
                if (user != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
