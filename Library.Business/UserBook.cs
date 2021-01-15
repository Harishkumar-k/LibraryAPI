using AutoMapper;
using Library.Contract.Business;
using Library.Contract.Data;
using Library.Model;
using Library.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Business
{
    public class UserBook : IUserBook
    {
        public readonly IUserBookdata userbookdata;
        private readonly IMapper Mapper;

        public UserBook(IUserBookdata Userbookdata, IMapper mapper)
        {
            userbookdata = Userbookdata;
            Mapper = mapper;
        }

        public string AddUserBook(UserBookVm adduserbook) {
            DateTime dt = DateTime.Now;
            adduserbook.Date_of_Issue = dt;
            adduserbook.Return_Date = dt.AddDays(3);
            return userbookdata.AddUserBook(Mapper.Map<UserBookM>(adduserbook));
        }

        public List<UserBookVm> GetAllUserBook(int userid) =>
            Mapper.Map<List<UserBookVm>>(userbookdata.GetAllUserBook(userid));

        public List<UserBookVm> GetUserBookbyUserid(int userid) {
            List<UserBookVm> usrbook = Mapper.Map<List<UserBookVm>>(userbookdata.GetUserBookbyUserid((userid)));
            DateTime dt = DateTime.Now;
            foreach (var ele in usrbook)
            {
                if((dt - ele.Return_Date).Days >= 1){
                    ele.Fine_Amount = Math.Abs((dt - ele.Return_Date).Days * 15);
                }  
            }
            return usrbook;
        }
            
        public string UpdateUserBook(UserBookVm userbook) =>
            userbookdata.UpdateUserBook(Mapper.Map<UserBookM>(userbook));
    }
}
