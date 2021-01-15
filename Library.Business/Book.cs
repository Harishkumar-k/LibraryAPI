using Library.Contract.Business;
using Library.Contract.Data;
using Library.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Library.Model;

namespace Library.Business
{
    public class Book : IBook
    {
        public readonly IBookdata bookdata;
        private readonly IMapper Mapper;

        public Book(IBookdata Bookdata, IMapper mapper)
        {
            Mapper = mapper;
            bookdata = Bookdata;
        }

        public List<BookAuthorVm> GetAllAuthor() =>
            Mapper.Map<List<BookAuthorVm>>(bookdata.GetAllAuthor());

        public List<BookVm> GetAllBooks() =>
            Mapper.Map<List<BookVm>>(bookdata.GetAllBooks());

        public List<BookVm> GetbooksbyAuthor(int Authorid) =>
            (Authorid != 0) ? Mapper.Map<List<BookVm>>(bookdata.GetbooksbyAuthor(Authorid)):throw new Exception("Author is not valid");

        public BookVm GetBooksByID(int bookid) {

            string category = null;
            var obj = bookdata.GetBooksByID(bookid);
            foreach(var ele in obj.BookCategory)
            {
                if (category == null)
                {
                    category = ele.Category_Name;
                }
                else
                {
                    category = category + "," + ele.Category_Name;
                }
            }
            var resultBook= Mapper.Map<BookVm>(bookdata.GetBooksByID(bookid));
            resultBook.BooksCategory = category;
            return resultBook;
        }
           

        public List<BookVm> GetbooksbyName(string bookname) =>
            (bookname != null) ? Mapper.Map<List<BookVm>>(bookdata.GetbooksbyName(bookname)) : throw new Exception("bookname is nothing");

        public List<BookVm> GetBooksbyRating(int ratingid) =>
            Mapper.Map<List<BookVm>>(bookdata.GetBooksbyRating(ratingid));

        public List<BookNewCountVm> GetNewBooksCount()
        {
            throw new NotImplementedException();
        }

        public List<BookCategoryVm> GetTypesOfCategory() =>
            Mapper.Map<List<BookCategoryVm>>(bookdata.GetTypesOfCategory());

        public List<BookRatingVm> GetTypesOfRating() =>
            Mapper.Map<List<BookRatingVm>>(bookdata.GetTypesOfRating());

        public List<BookVm> ShowBooksbyAvailabilty()
        {
            throw new NotImplementedException();
        }
    }
}
