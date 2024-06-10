using BlogPhotographerSystem_Core.Context;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.IServices;
using BlogPhotographerSystem_Core.Models.Entity;
using BlogPhotographerSystem_Infra.Repos;
using BlogPhotographerSystem_Infra.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Serilog;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Photographer Blog System",
    });

    // using System.Reflection;
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

//IService and ServiceClass
builder.Services.AddScoped<IBlogService, BlogService>();
builder.Services.AddScoped<IBlogAttachementService, BlogAttachementService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IGalleryService, GalleryService>();
builder.Services.AddScoped<IProblemService, ProblemService>();
builder.Services.AddScoped<IServiceService, ServiceService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IContactRequestService, ContactRequestService>();
builder.Services.AddScoped<ILoginService, LoginService>();
//IRepos and ReposClass
builder.Services.AddScoped<IBlogRepos, BlogRepos>();
builder.Services.AddScoped<IBlogAttachementRepos, BlogAttachementRepos>();
builder.Services.AddScoped<ICategoryRepos, CategoryRepos>();
builder.Services.AddScoped<IUserRepos, UserRepos>();
builder.Services.AddScoped<IGalleryRepos, GalleryRepos>();
builder.Services.AddScoped<IProblemRepos, ProblemRepos>();
builder.Services.AddScoped<IServiceRepos, ServiceRepos>();
builder.Services.AddScoped<IOrderRepos, OrderRepos>();
builder.Services.AddScoped<IContactRequestRepos, ContactRequestRepos>();
builder.Services.AddScoped<ILoginRepos, LoginRepos>();
builder.Services.AddDbContext<BlogPhotographerSystemDBContext>(option => option.UseMySQL(builder.Configuration.GetConnectionString("mysqlconnect")));

//serilog
var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
Serilog.Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(configuration).
                WriteTo.File(configuration.GetValue<string>("LogerPath"), rollingInterval: RollingInterval.Day).
                CreateLogger();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    Log.Information("Application started");
    Log.Debug("This is a debug message. It provides detailed debugging information.");
    Log.Warning("Configuration might be incomplete. Check appsettings.json.");
    Log.Error("Failed to connect to the database.");
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
