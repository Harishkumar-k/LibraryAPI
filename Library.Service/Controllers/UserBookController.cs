using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Library.Contract.Business;
using Library.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Library.Service.Controllers
{
    [Authorize]
    [Route("[controller]/[action]")]
    [ApiController]
    public class UserBookController : ControllerBase
    {
        private readonly IMapper Mapper;
        public IUserBook userbook;

        public UserBookController(IUserBook Userbook, IMapper mapper)
        {
            Mapper = mapper;
            userbook = Userbook;
        }

        [HttpPost]
        public string AddUserBook([FromBody]UserBookVm usrbook) =>
            JsonConvert.SerializeObject(userbook.AddUserBook(Mapper.Map<UserBookVm>(usrbook)));

        [HttpGet]
        public List<UserBookVm> GetAllUserBook(int userid) =>
            Mapper.Map<List<UserBookVm>>(userbook.GetAllUserBook(userid));

        [HttpGet]
        public List<UserBookVm> GetUserBookbyUserid(int userid) =>
            Mapper.Map<List<UserBookVm>>(userbook.GetUserBookbyUserid(userid));

        [HttpPut]
        public string UpdateUserBook(UserBookVm updateuserbook) =>
             JsonConvert.SerializeObject(userbook.UpdateUserBook(Mapper.Map<UserBookVm>(updateuserbook)));
    }
}