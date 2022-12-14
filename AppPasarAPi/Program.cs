using AppPasarApplication.ConfigProfile;
using AppPasarApplication.Default_Services.CustomerServices;
using AppPasarApplication.Default_Services.SupplierServices;
using AppPasarApplication.Default_Services.TransactionDetailServices;
using AppPasarApplication.Default_Services.TransactionServices;
using AppPasarDB.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// connect DB
var connectionString = builder.Configuration.GetConnectionString("DBConnection");
builder.Services.AddDbContext<PasarContext>(option => option.UseSqlServer(connectionString));

// Automapper
var config = new AutoMapper.MapperConfiguration(cfg =>
{
    cfg.AddProfile(new ConfigurationProfile());
});
var mapper = config.CreateMapper();

//Addservice to conatiner
builder.Services.AddSingleton(mapper);
builder.Services.AddTransient<ICustomerAppService, CustomerAppService>();
builder.Services.AddTransient<ISupplierAppService, SupplierAppService>();
builder.Services.AddTransient<ITransactionAppService, TransactionAppService>();
builder.Services.AddTransient<ITransactionDetailAppService, TransactionDetailAppService>();

builder.Services.AddControllers();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
