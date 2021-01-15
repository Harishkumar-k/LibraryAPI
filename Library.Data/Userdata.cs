using Dapper;
using Library.Contract.Data;
using Library.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper.Contrib.Extensions;
using Library.Contract.Framework;

namespace Library.Data
{
    public class Userdata : BaseData,IUserdata
    {
        public Userdata(IAppsetting dbConnectionSetting): base(dbConnectionSetting){}

        public string AddUser(UserM user)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                user.User_Status = "Active";
                //var userid = connection.Insert(user);
                connection.Execute("dbo.Library_AddUser", user, commandType: CommandType.StoredProcedure);
            }
            return "Row inserted";
        }

        public UserM CheckUser(string Email, string password)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Email", Email);
                parameters.Add("@Password", password);
                var result = connection.QuerySingle<UserM>("dbo.Library_CheckUser", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public UserM GetUserDetails(int user_id)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                //var userdata = connection.Get<UserM>(user_id);
                var userdata = connection.QuerySingle<UserM>("dbo.Library_GetUserDetails", new { User_ID = user_id }, commandType: CommandType.StoredProcedure);
                return userdata;
            }
        }

        public string UpdateUserDetails(UserM user)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                //connection.Update(user);
                connection.Execute("dbo.Library_UpdateUserDetails", user,commandType: CommandType.StoredProcedure);           
            }
            return "UserData Updated";
        }
    }
}
