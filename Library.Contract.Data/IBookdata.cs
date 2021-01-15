using Library.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Contract.Data
{
    public interface IBookdata
    {
        BookM GetBooksByID(int bookid);
        List<BookM> GetAllBooks();
        List<BookM> GetbooksbyAuthor(int Authorid);
        List<BookM> GetbooksbyName(string bookname);
        List<BookM> GetBooksbyRating(int ratingid);
        List<BookM> ShowBooksbyAvailabilty();
        List<BookAuthorM> GetAllAuthor();
        List<BookRatingM> GetTypesOfRating();
        List<BookCategoryM> GetTypesOfCategory();
        List<BookNewCountM> GetNewBooksCount();



    }
}
