using AutoMapper;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using System.ComponentModel.Design;
using Uyanda.ForeignCurrency.Application;
using Uyanda.ForeignCurrency.Application.Integration;
using Uyanda.ForeignCurrency.Integration;
using Uyanda.ForeignCurrency.Integration.ApiLayer;

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
    services.AddApplicationModule().AddIntegrationModule();

    //services.AddHttpClient<IApiLayerIntegration, ApiLayerIntegration>();

    //AutoMapper
    services.AddTransient(_ => Mapper());
}

static IMapper Mapper()
{
    var config = new MapperConfiguration(cfg =>
    {
        cfg.AddMaps(typeof(IntegrationModule));
    });

    config.AssertConfigurationIsValid();

    config.CompileMappings();

    return config.CreateMapper();
}