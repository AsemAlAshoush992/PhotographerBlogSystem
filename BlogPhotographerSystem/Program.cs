using BlogPhotographerSystem_Core.Context;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.IServices;
using BlogPhotographerSystem_Core.Models.Entity;
using BlogPhotographerSystem_Infra.Repos;
using BlogPhotographerSystem_Infra.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
