using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ZendoAPI.Data;
using ZendoAPI.Mapper;
using ZendoAPI.Models.Dto;
using ZendoAPI.Repositories.Categorias;
using ZendoAPI.Repositories.Comentarios;
using ZendoAPI.Repositories.Statuse;
using ZendoAPI.Repositories.Tickets;
using ZendoAPI.Repositories.Usuarios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ZendoDBContext>(Options =>
Options.UseSqlServer(builder.Configuration.GetConnectionString("ZendoConnectionString")));

//Repositories
builder.Services.AddScoped<IUserRepository, SQLUsuarioRepository>();
builder.Services.AddScoped<ICategoriaRepository, SQLCategoriaRepository>();
builder.Services.AddScoped<IComentarioRepository, SQLComentarioRepository>();
builder.Services.AddScoped<IStatusRepository, SQLStatusRepository>();
builder.Services.AddScoped<ITicketRepository, SQLTicketRepository>();

//DTOs
builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));

//Services

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
