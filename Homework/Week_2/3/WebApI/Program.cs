using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.Database;
using DataAccess.Concrete.InMemory;
using Entities.Concrete.Models.Db;
using System.Text.Json.Serialization;

namespace WebApI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers()
                .AddJsonOptions(j => j.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<CoursedbContext>();

            /*// Using in-memory
            builder.Services.AddScoped<ICourseDAL, CourseDAL>();
            builder.Services.AddScoped<IInstructorDAL, InstructorDAL>();
            builder.Services.AddScoped<ICategoryDAL, CategoryDAL>();*/

            // Using database
            builder.Services.AddScoped<ICourseDAL, EFCourseDAL>();
            builder.Services.AddScoped<IInstructorDAL, EFInstructorDAL>();
            builder.Services.AddScoped<ICategoryDAL, EFCategoryDAL>();

            builder.Services.AddScoped<ICourseManager, CourseManager>();
            builder.Services.AddScoped<ICategoryManager, CategoryManager>();
            builder.Services.AddScoped<IInstructorManager, InstructorManager>();

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
