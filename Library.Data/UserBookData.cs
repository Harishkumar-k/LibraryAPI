using Dapper;
using Library.Contract.Data;
using Library.Contract.Framework;
using Library.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Library.Data
{
    public class UserBookData : BaseData,IUserBookdata
    {
        public UserBookData(IAppsetting dbConnectionSetting) : base(dbConnectionSetting) { }

        public string AddUserBook(UserBookM adduserbook)
        {

            using (IDbConnection connection = GetConnection())
            {
                connection.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@User_ID", adduserbook.User_ID,DbType.Int32);
                parameters.Add("@Book_id", adduserbook.Book_id);
                parameters.Add("@Date_of_Issue", adduserbook.Date_of_Issue);
                parameters.Add("@Status_Id", adduserbook.Status_Id);
                parameters.Add("@Return_Date", adduserbook.Return_Date);
                parameters.Add("@New_Book_Count", adduserbook.New_Book_Count);
                connection.Execute("dbo.Library_AddUserBook", parameters, commandType: CommandType.StoredProcedure);
            }
            return "Row Inserted";
        }

        public List<UserBookM> GetAllUserBook(int userid)
        {
            using (IDbConnection connection = GetConnection())
            {
                return connection.Query<UserBookM>("dbo.Library_GetAllUserBookbyID", new { User_ID = userid }, commandType: CommandType.StoredProcedure).ToList();
            }

        }

        public List<UserBookM> GetUserBookbyUserid(int userid)
        {
            using (IDbConnection connection = GetConnection())
            {
                return connection.Query<UserBookM>("dbo.Library_UserBookDataStatus", new {User_ID=userid }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public string UpdateUserBook(UserBookM updateuserbook)
        {
            using (IDbConnection connection = GetConnection())
            {
                    connection.Open();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@User_ID", updateuserbook.User_ID);
                    parameters.Add("@UserBook_id", updateuserbook.UserBook_id);
                    parameters.Add("@Book_id", updateuserbook.Book_id);
                    parameters.Add("@New_Book_Count", updateuserbook.New_Book_Count);
                    parameters.Add("@User_Return_Date", DateTime.Now);
                    connection.Execute("dbo.Library_UpdateUserBook", parameters, commandType: CommandType.StoredProcedure);
            }
            return "Data Updated";
        }
    }

}
