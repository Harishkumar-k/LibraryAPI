using Library.Contract.Framework;
using Library.Framework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Service
{
    public static class LibraryServiceExtension
    {
        public static IServiceCollection AddLibraryDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            
            Appsetting appsetting = new Appsetting();
            //appsetting.Connection_string = "Server=tcp:mytestdbprod.database.windows.net,1433;Initial Catalog=MyTestDB;Persist Security Info=False;User ID=gssharik;Password=harish*123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            //appsetting.Connection_string = @"Server=sql.freeasphost.net\MSSQL2016;Initial Catalog=gsshari_test;User ID=gsshari;Password=harish*123;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;";
            services.Configure<Appsetting>(configuration.GetSection("AppSetting"));
            configuration.Bind("AppSetting", appsetting);
            services.AddSingleton<IAppsetting>(appsetting);
            return services;
        }
    }
}
