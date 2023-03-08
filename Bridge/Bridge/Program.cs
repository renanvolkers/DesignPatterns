
using Bridge.EndPoints;
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;

namespace Bridge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers().AddJsonOptions(options =>
           options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(op =>
            {
                op.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Bridge",
                    Version = "version",
                    Description = "The Goal project is show the use pattern Bridge",
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

            app.MapBridgeAppEndPoints();
            app.Run();
        }
    }
}