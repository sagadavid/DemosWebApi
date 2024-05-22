using DemosWebApi;
using FirstWebApi;
using FirstWebApi.Models;
using Microsoft.Build.Framework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IPostService, PostService>();//dotnet add package Microsoft.Extensions.DependencyInjection

//builder.Services.AddScoped<IInjectionService, InjectionService>();
//builder.Services.AddSingleton<IInjectionService, InjectionService>();
builder.Services.AddTransient<IInjectionService, InjectionService>();

//builder.Services.AddScoped<IScopedService, ScopedService>();
//builder.Services.AddTransient<ITransientService, TransientService>();
//builder.Services.AddSingleton<ISingletonService, SingletonService>();

builder.Services.AddServicesAtOnce();//multiple services added at once !

//manage multiple services which implement same interface
builder.Services.AddKeyedScoped<IDataBaseService, SqlService>("sqlService");
builder.Services.AddKeyedScoped<IDataBaseService, CosmosService>("cosmosService");

//keyed services as transient, scoped, singleton
//builder.Services.AddKeyedTransient<IDataBaseService, SqlService>("sqlService");
//builder.Services.AddKeyedTransient<IDataBaseService, CosmosService>("cosmosService");
//builder.Services.AddKeyedSingleton<IDataBaseService, SqlService>("sqlService");
//builder.Services.AddKeyedSingleton<IDataBaseService, CosmosService>("cosmosService");

var app = builder.Build();

//scoped service for limited duration in program startup
using (var serviceScope = app.Services.CreateScope())
{
    var services = serviceScope.ServiceProvider;

    var tempoService = services.GetRequiredService<IInjectionService>();
    var message = tempoService.HilsPublikum();
    Console.WriteLine(message);
}

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
