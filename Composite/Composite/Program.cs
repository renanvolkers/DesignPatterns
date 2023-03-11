
using Microsoft.OpenApi.Models;

namespace Composite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen(op =>
            {
                op.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "",
                    Version = "version",
                    Description = "The Goal project is show the use pattern Builder",
                    Contact = new OpenApiContact
                    {
                        Name = "Renan Alpoim Volkers",
                        Email = "renanvolkers@hotmail.com",
                        Url = new Uri("https://www.linkedin.com/in/renanvolkers/"),

                    }
                });

            });
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.Run();
        }
    }
}