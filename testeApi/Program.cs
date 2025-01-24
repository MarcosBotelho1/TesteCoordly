using Microsoft.EntityFrameworkCore;
using ProductManagementApi.Data; // Namespace do AppDbContext (ajuste se necessário)

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Configura o DbContext com a string de conexão definida no appsettings.json
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configura o Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Adiciona suporte a controllers
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

// Mapeia os controllers
app.MapControllers();

app.Run();
