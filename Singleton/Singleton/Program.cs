using Microsoft.OpenApi.Models;
using Singleton.Domain;
using Singleton.EndPoints;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers().AddJsonOptions(options =>
           options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
builder.Services.Configure<UnitOptions>(builder.Configuration.GetSection("Units"));
builder.Services.AddSingleton<ISingletonService, SingletonService>();
builder.Services.AddSwaggerGen(op =>
{
    op.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Singleton",
        Version = "version",
        Description = "The Goal project is show the use pattern Singleton",
        Contact = new OpenApiContact
        {
            Name = "Renan Alpoim Volkers",
            Email = "renanvolkers@hotmail.com",
            Url = new Uri("https://www.linkedin.com/in/renanvolkers/"),

        }
    });

});
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapSingletonAppEndPoints();
app.Run();


