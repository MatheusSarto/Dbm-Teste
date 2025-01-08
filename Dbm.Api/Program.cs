using Dbm.Api.Controllers;
using Dbm.Api.Data;
using Dbm.Api.Handlers;
using Dbm.Api.Repositories;
using Dbm.Core.Handlers;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var cnnStr = builder.Configuration.GetConnectionString("DefaultConnection") ?? string.Empty;
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(cnnStr));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x =>
{
    x.CustomSchemaIds(n => n.FullName);
});

builder.Services.AddTransient<IHandlerCliente, ClienteHandler>();
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();

var app = builder.Build(); 
if (app.Environment.IsDevelopment())
{ 
    app.UseDeveloperExceptionPage(); 
}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection(); 
app.UseAuthorization(); 

app.MapControllers(); 
app.Run();