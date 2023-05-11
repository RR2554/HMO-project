using AutoMapper;
using Bll;
using Dal;
using Entity;
using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMemberBll, MemberBll>();
builder.Services.AddScoped<IMemberDal, MemberDal>();
builder.Services.AddScoped<IVaccineBll, VaccineBll>();
builder.Services.AddScoped<IVaccineDal, VaccineDal>();
builder.Services.AddScoped<ICorona_DetailsBll, Corona_DetailsBll>();
builder.Services.AddScoped<ICorona_DetailsDal, Corona_DetailsDal>();
builder.Services.AddDbContext<DB>();


var mapperConfig = new MapperConfiguration(mc =>
{

    mc.AddProfile(new MapperProfile());
});
IMapper mapper = mapperConfig.CreateMapper();

builder.Services.AddSingleton(mapper);

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(x => x.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin());
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
