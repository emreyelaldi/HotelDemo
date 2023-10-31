using Hotel.API.Data;
using Hotel.API.Managers;
using Hotel.API.Managers.Abstract;
using Hotel.API.Utilities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<HotelDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));
builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);

builder.Services.AddControllers().AddNewtonsoftJson(opt =>
  opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<IHotelManager, HotelManager>();
builder.Services.AddScoped<IContactInfoManager, ContactInfoManager>();


builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();
app.Run();
