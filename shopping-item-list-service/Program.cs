using Microsoft.EntityFrameworkCore;
using ShoppingItemService.Data;
using dotenv.net;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

DotEnv.Load();

var connectionString = $"server={Environment.GetEnvironmentVariable("DATASOURCE_URL")};" +
                       $"user id={Environment.GetEnvironmentVariable("DATASOURCE_USERNAME")};" +
                       $"password={Environment.GetEnvironmentVariable("DATASOURCE_PASSWORD")};"+
                       $"database={Environment.GetEnvironmentVariable("DATABASE")};";

builder.Services.AddDbContext<ShoppingItemContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.WebHost.UseUrls("http://localhost:8080");

var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

app.Run();