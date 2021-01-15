using AutoMapper;
using Library.Contract.Business;
using Library.Contract.Data;
using Library.Model;
using Library.ViewModel;
using System;
using System.Collections.Generic;

namespace Library.Business
{
    public class User : IUser
    {
        private readonly IMapper Mapper;
        public IUserdata userdata;

        public User(IUserdata Userdata, IMapper mapper)
        {
            Mapper = mapper;
            userdata = Userdata;
        }

        public string AddUser(UserVm user) =>
            userdata.AddUser(Mapper.Map<UserM>(user));

        public UserVm CheckUser(string Email, string password) =>
            Mapper.Map<UserVm>(userdata.CheckUser(Email, password));


        public UserVm GetUserDetails(int user_id) =>
            Mapper.Map<UserVm>(userdata.GetUserDetails(user_id));

        public string UpdateUserDetails(UserVm userdetails) =>
            userdata.UpdateUserDetails(Mapper.Map<UserM>(userdetails));
    }
}
