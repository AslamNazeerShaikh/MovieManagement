using Microsoft.EntityFrameworkCore;

using MovieManagement.DataAccess.Context;
using MovieManagement.DataAccess.Implementation;
using MovieManagement.Domain.Repository;

namespace MovieManagement.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Add Entity Framework Core DbContext & SQLite Service to DI
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlite(builder.Configuration.GetConnectionString("WebApiDatabase")));

            // Add services to DI
            builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

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