using Toto.Data;

var builder = WebApplication.CreateBuilder(args);

//informa ao dotnet que usará controllers na aplicação
builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

app.MapControllers();

app.Run();
