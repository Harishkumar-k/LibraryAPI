using Library.ViewModel;
using System;
using System.Collections.Generic;

namespace Library.Contract.Business
{
    public interface IUser
    {
        UserVm GetUserDetails(int user_id);
        string UpdateUserDetails(UserVm user);
        string AddUser(UserVm user);
        UserVm CheckUser(string Email, string password);
        //void UpdateUser(int user_id);
    }
}
