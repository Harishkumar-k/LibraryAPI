using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Library.Model;
using Library.ViewModel;

namespace TypeResolver
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BookM, BookVm>().ReverseMap();
            CreateMap<UserM, UserVm>().ReverseMap();
            CreateMap<BookAuthorM, BookAuthorVm>().ReverseMap();
            CreateMap<BookCategoryM, BookCategoryVm>().ReverseMap();
            CreateMap<BookNewCountM, BookNewCountVm>().ReverseMap();
            CreateMap<BookRatingM, BookRatingVm>().ReverseMap();
            CreateMap<UserBookM, UserBookVm>().ReverseMap();
            CreateMap<UserBookM, UserBookVm>().ReverseMap();
        }
    }
}
