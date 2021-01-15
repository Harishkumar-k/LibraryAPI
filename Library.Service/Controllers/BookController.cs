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

namespace Library.Service.Controllers
{
    [Authorize]
    [Route("[controller]/[action]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IMapper Mapper;
        public IBook book;

        public BookController(IBook Book,IMapper mapper)
        {
            Mapper = mapper;
            book = Book;
        }

        [HttpGet]
        public BookVm GetBooksByID(int bookid) =>
            Mapper.Map<BookVm>(book.GetBooksByID(bookid));

        [HttpGet]
        public List<BookVm> GetAllBooks() =>
            Mapper.Map<List<BookVm>>(book.GetAllBooks());

        [HttpGet]
        public List<BookVm> GetbooksbyAuthor([FromBody]BookAuthorVm Author) =>
            Mapper.Map<List<BookVm>>(book.GetbooksbyAuthor(Author.Author_Id));

        [HttpGet]
        public List<BookVm> GetbooksbyName(string Book_Name) =>
            Mapper.Map<List<BookVm>>(book.GetbooksbyName(Book_Name));

        [HttpGet]
        public List<BookCategoryVm> GetTypesOfCategory() =>
            Mapper.Map<List<BookCategoryVm>>(book.GetTypesOfCategory());

        [HttpGet]
        public List<BookRatingVm> GetTypesOfRating() =>
            Mapper.Map<List<BookRatingVm>>(book.GetTypesOfRating());

        [HttpGet]
        public List<BookAuthorVm> GetAllAuthor()=>
            Mapper.Map<List<BookAuthorVm>>(book.GetAllBooks());

        [HttpGet]
        public List<BookVm> GetBooksbyRating([FromBody]BookRatingVm ratingid) =>
            Mapper.Map<List<BookVm>>(book.GetBooksbyRating(ratingid.Rating_id));


    }
}