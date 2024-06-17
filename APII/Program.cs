using Business.Manager;
using Business.Services;
using Data.Context;
using Data.DAL.Customer;
using Data.Repositories.Db1Repository;
using Data.Repositories.EntityRepos;
using Data.Services.EntityService;
using DTO.AutoMapper;
using DTO.AutoMapper.CustomerMapper;
using DTO.AutoMapper.LazerMapper;
using Microsoft.Extensions.DependencyInjection;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<AppDbContext>();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddAutoMapper(typeof(CustomerMapper));
builder.Services.AddAutoMapper(typeof(LazerMapper));
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ILazerAppointmentService, LazerAppointmentManager>();
builder.Services.AddScoped<ILazerAppointmentDAL, LazerAppointmentRepository>();
builder.Services.AddScoped<ICustomerService, CustomerManager>();
builder.Services.AddScoped<ICustomerDAL, CustomerRepository>();
builder.Services.AddScoped<IMasterService, MasterManager>();
builder.Services.AddScoped<IMasterDAL, MasterRepository>();
builder.Services.AddScoped<ICosmetologyService, CosmetologyAppointmentManager>();
builder.Services.AddScoped<ICosmetologyDAL, CosmetologyRepository>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP reque
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
