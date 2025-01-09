using Dbm.Api.Controllers;
using Dbm.Api.Data;
using Dbm.Api.Handlers;
using Dbm.Api.Repositories;
using Dbm.Api.Repositories.Interfaces;
using Dbm.Core.Handlers;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
    .AddJsonOptions(options => 
    { 
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve; 
        options.JsonSerializerOptions.WriteIndented = true; 
    });

var cnnStr = builder.Configuration.GetConnectionString("DefaultConnection") ?? string.Empty;
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(cnnStr));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x =>
{
    x.CustomSchemaIds(n => n.FullName);
});

// Injetando dependencias
builder.Services.AddTransient<IHandlerCliente, ClienteHandler>();
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();

builder.Services.AddTransient<IProtocoloHandler, ProtocoloHandler>();
builder.Services.AddTransient<IProtocolosRepository, ProtocolosRepository>();

builder.Services.AddTransient<IStatusProtocolo, HandlerStatusProtocolo>();
builder.Services.AddTransient<IStatusProtocoloRepository, StatusProtocoloRepository>();

builder.Services.AddTransient<IAcompanhamentoProtocoloRepository, AcompanhamentoProtocoloRepository>();
builder.Services.AddTransient<IHandlerProtocoloFollow, HandlerProtocoloFollows>();

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