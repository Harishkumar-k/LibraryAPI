using Library.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Contract.Business
{
    public interface IBook
    {
        BookVm GetBooksByID(int bookid);
        List<BookVm> GetAllBooks();
        List<BookVm> GetbooksbyAuthor(int Authorid);
        List<BookVm> GetbooksbyName(string bookname);
        List<BookVm> GetBooksbyRating(int ratingid);
        List<BookVm> ShowBooksbyAvailabilty();
        List<BookAuthorVm> GetAllAuthor();
        List<BookRatingVm> GetTypesOfRating();
        List<BookCategoryVm> GetTypesOfCategory();
        List<BookNewCountVm> GetNewBooksCount();


    }
}
