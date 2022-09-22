
using Microsoft.EntityFrameworkCore;
using Motocicleta.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Context>(options => options.UseMySQL("server=localhost;initial catalog=MotocicletasApi;uid=root;pwd=", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.29-mysql")));
//builder.Services.AddDbContext<Context>
//  (options => options.UseMySQL(
//    "server=localhost;initial catalog=MontadoraCarroApi;uid=root;pwd=",
//  Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.29-mysql")));

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
