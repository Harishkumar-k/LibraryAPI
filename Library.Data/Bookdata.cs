using AutoMapper;
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
    public class Bookdata : BaseData,IBookdata
    {

        public Bookdata(IAppsetting dbConnectionSetting) : base(dbConnectionSetting)
        {

        }

        public List<BookAuthorM> GetAllAuthor()
        {
            throw new NotImplementedException();
        }

        public List<BookM> GetAllBooks()
        {
            var conn = GetConnection();
            using (IDbConnection connection = GetConnection())
            {
                connection.Open();
                return connection.Query<BookM>("dbo.Library_GetAllBooks", commandType: CommandType.StoredProcedure).ToList();
            }
        }

        //public List<BookM> GetAllBooks()
        //{
        //    using (SqlConnection connection = new SqlConnection(ConnectionString))
        //    {
        //        using (var multipleResults = connection.QueryMultiple("dbo.Library_GetAllBooks", commandType: CommandType.StoredProcedure))
        //        {
        //            List<BookM> userBook = multipleResults.Read<BookM>().ToList();
        //            var category = multipleResults.Read<BookCategoryM>().ToList();
        //            List<BookM> bookMs = new List<BookM>();
        //            BookM usrBook = new BookM();
        //            foreach (BookM ele in userBook)
        //            {
        //                List<BookCategoryM> bookCategories = new List<BookCategoryM>();
        //                foreach (var lem in category)
        //                {
        //                    if (ele.Book_id == lem.Book_id)
        //                    {
        //                        bookCategories.Add(lem);
        //                    }
        //                }
        //                //userBook.AddRange(bookCategories);
        //                usrBook.BookCategory.AddRange(bookCategories);
        //                usrBook.Author_Name = ele.Author_Name;
        //                usrBook.Book_Name = ele.Book_Name;
        //                bookMs.Add(usrBook);
        //            }
        //            return bookMs;
        //        }
        //    }

        //}

        public List<BookCategoryM> GetTypesOfCategory()
        {
            using (IDbConnection connection = GetConnection())
            {
                connection.Open();
                return connection.Query<BookCategoryM>("dbo.Library_GetTypesOfCategory", commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public List<BookM> GetbooksbyAuthor(int Authorid)
        {
            using (IDbConnection connection = GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Author_Id",Authorid);
                return connection.Query<BookM>("dbo.Library_GetbooksbyAuthor", parameters, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public List<BookM> GetbooksbyName(string bookname)
        {
            throw new NotImplementedException();
        }

        public List<BookM> GetBooksbyRating(int ratingid)
        {
            using (IDbConnection connection = GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Rating_id", ratingid);
                
                    return connection.Query<BookM>("dbo.Library_GetBooksbyRating", parameters, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public List<BookRatingM> GetTypesOfRating()
        {
            using (IDbConnection connection = GetConnection())
            {
                connection.Open();
                return connection.Query<BookRatingM>("dbo.Library_GetTypesOfRating", commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public List<BookM> ShowBooksbyAvailabilty()
        {
            throw new NotImplementedException();
        }

        public List<BookNewCountM> GetNewBooksCount()
        {
            throw new NotImplementedException();
        }

        public BookM GetBooksByID(int bookid)
        {
            using (IDbConnection connection = GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Book_id", bookid);
                using (var multipleResults = connection.QueryMultiple("dbo.Library_GetBooksByID", parameters, commandType: CommandType.StoredProcedure))
                {
                    var userBook = multipleResults.Read<BookM>().SingleOrDefault();
                    var category = multipleResults.Read<BookCategoryM>().ToList();
                    if(userBook!=null && category != null)
                    {
                        userBook.BookCategory = new List<BookCategoryM>();
                        userBook.BookCategory.AddRange(category);
                    }
                    return userBook;
                } 
            }
        }
    }
}
