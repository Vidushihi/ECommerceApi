
using ECommerceApi.Dal;
using ECommerceApi.Dal.Repositories;
using ECommerceApi.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //builder.Services.AddDbContext<ECommerceDbContext>();
            builder.Services.AddDbContext<ECommerceDbContext>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("ECommerceDb"));
            });

            // Add services to the container.

            builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
