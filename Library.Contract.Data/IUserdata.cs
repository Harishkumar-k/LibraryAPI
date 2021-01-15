using Library.Model;
using System;
using System.Collections.Generic;

namespace Library.Contract.Data
{
    public interface IUserdata
    {
        UserM GetUserDetails(int user_id);
        string UpdateUserDetails(UserM user);
        string AddUser(UserM user);
        UserM CheckUser(string Email, string password);
    }
}
