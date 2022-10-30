using Microsoft.EntityFrameworkCore;
using ToDoAPI.models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<ToDoContext>(opt
    => opt.UseInMemoryDatabase("ToDoList"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapControllers();

app.Run();