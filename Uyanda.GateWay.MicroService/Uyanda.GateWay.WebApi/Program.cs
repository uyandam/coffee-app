using Uyanda.GateWay.Application.Microservices.CoffeeShopMicroService;
using Uyanda.GateWay.Application;
using Uyanda.GateWay.Integration;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using AutoMapper;


var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//add cors code 
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

RegisterServices(builder.Configuration, builder.Services);


var app = builder.Build();

app.UseCors("corsapp");

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
        .AddIntegrationModule();

    services.AddHttpClient();

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