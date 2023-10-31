using api.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(ops => 
{
    //ops.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString"));
    ops.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnectionString"));

});
var app = builder.Build();

// Configure the HTTP request pipeline.


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
