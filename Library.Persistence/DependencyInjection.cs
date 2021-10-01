using Library.Application.Common.Repositories;
using Library.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<LibraryContext>(opt =>
            {
                opt.UseNpgsql(configuration.GetConnectionString("LibraryDB"),
                    option =>
                    {
                        option.CommandTimeout(180);
                        option.EnableRetryOnFailure(5, TimeSpan.FromSeconds(3), null);
                    });
            });

            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IPublishingHouseRepository, PublishingHouseRepository>();
            services.AddScoped<IWriterRepository, WriterRepository>();

            return services;
        }
    }
}
