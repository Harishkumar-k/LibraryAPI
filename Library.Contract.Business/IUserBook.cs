using Library.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Contract.Business
{
    public interface IUserBook
    {
        string AddUserBook(UserBookVm book);
        string UpdateUserBook(UserBookVm userbook);
        List<UserBookVm> GetAllUserBook(int userid);
        List<UserBookVm> GetUserBookbyUserid(int userid);
    }
}
