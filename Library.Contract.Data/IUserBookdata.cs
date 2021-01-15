using Library.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Contract.Data
{
    public interface IUserBookdata
    {
        string AddUserBook(UserBookM book);
        string UpdateUserBook(UserBookM userbook);
        List<UserBookM> GetAllUserBook(int userid);
        List<UserBookM> GetUserBookbyUserid(int userid);
    }
}
