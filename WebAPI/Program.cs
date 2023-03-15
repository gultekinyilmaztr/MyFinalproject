using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Autofac;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new AutofacBusinessModule());
});

// Add services to the container.
//Autodac,Ninjet,CastleWindsor,StrucureMap,LightInject,DryInject --> IoC Container
//AOP
builder.Services.AddControllers();
//builder.Services.AddSingleton<IProductService,ProductManager>(); // T�m bellekte 1 manager olu�turuyor ve hepis bu referans� g�r�yor.Bu heryerde yap�lan kulla�nlan bir teknik olup api ye �zel de�ildir.
//builder.Services.AddSingleton<IProductDal, EfProductDal>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
