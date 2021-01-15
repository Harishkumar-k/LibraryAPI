using AutoMapper;
using Library.Business;
using Library.Contract.Business;
using Library.Contract.Data;
using Library.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace TypeResolver
{
    public static class TypeResolver
    {
        public static IServiceCollection AddDependancies(this IServiceCollection services)
        {
            services.AddTransient<IBookdata, Bookdata>();
            services.AddTransient<IBook, Book>();
            services.AddTransient<IUserdata, Userdata>();
            services.AddTransient<IUser, User>();
            services.AddTransient<IUserBook, UserBook>();
            services.AddTransient<IUserBookdata, UserBookData>();
            services.AddAutoMapper(typeof(MappingProfile));
            return services;
        }
    }
}
