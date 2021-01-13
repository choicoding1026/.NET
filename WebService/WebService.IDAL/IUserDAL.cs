using System;
using System.Collections.Generic;
using WebService.Model;

namespace WebService.IDAL
{
    public interface IUserDAL
    {
        List<User> GetUserList();

        User GetUser(int userNo);

    }

}
