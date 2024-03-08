using MyTodo.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline;

app.MapGet("/", () => "Hello World!");
app.MapControllers();

// Routing

app.Run();
