using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Library.Contract.Business;
using Library.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace Library.Service.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper Mapper;
        public IUser user;

        public UserController(IUser User, IMapper mapper)
        {
            Mapper = mapper;
            user = User;
        }

        [HttpPost]
        public UserVm CheckUser(UserVm usertoken)
        {
            string tokenString;
            usertoken = user.CheckUser(usertoken.Email, usertoken.Password);
            if (usertoken.User_Status == "Active")
                {
                    var claimsdata = new[]
                    {
                        new Claim("Email",usertoken.Email),
                        new Claim("Password",usertoken.Password)
                    };
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("w2SoigJvVvuydwAJKuAVT6oRbtalqNDy"));
                    var signinCred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
                    var token = new JwtSecurityToken(
                        issuer: "http://localhost",
                        audience: "http://localhost",
                        expires: DateTime.Now.AddMinutes(100),
                        claims: claimsdata,
                        signingCredentials: signinCred
                        );
                    tokenString = new JwtSecurityTokenHandler().WriteToken(token);
                    usertoken.token = tokenString;
                    return usertoken;
            }
            else
            {
                return usertoken;
            }
        }
            
        [Authorize]
        [HttpGet]
        public UserVm GetUserDetails([FromBody]UserVm userid) =>
            Mapper.Map<UserVm>(user.GetUserDetails(userid.User_ID));

        [HttpPost]
        public string AddUser(UserVm adduser) =>
            JsonConvert.SerializeObject(user.AddUser(Mapper.Map<UserVm>(adduser)));

        [Authorize]
        [HttpPut]
        public string  UpdateUserDetails([FromBody]UserVm updateuser)=>
             JsonConvert.SerializeObject(user.UpdateUserDetails(Mapper.Map<UserVm>(updateuser)));
    }
}