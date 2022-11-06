using Uyanda.CoffeeShop.Application;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using AutoMapper;
using Uyanda.CoffeeShop.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

RegisterServices(builder.Configuration, builder.Services);

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


static void RegisterServices(IConfiguration configuration, IServiceCollection services)
{
    services.AddApplicationModule()
        .AddPersistenceModule();

    services.AddHttpClient();

    //AutoMapper
    services.AddTransient(_ => Mapper());
}

static IMapper Mapper()
{
    var config = new MapperConfiguration(cfg =>
    {
        cfg.AddMaps(typeof(PersistenceModule));
    });

    config.AssertConfigurationIsValid();

    config.CompileMappings();

    return config.CreateMapper();
}