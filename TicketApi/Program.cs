using Microsoft.EntityFrameworkCore;using System.Text.Json.Serialization;
using TicketApi;
using TicketApi.Data;using TicketApi.Interfaces;
using TicketApi.Repositories;
using TicketApi.Services;

var builder = WebApplication.CreateBuilder(args);// Add services to the container.builder.Services.AddControllers();
builder.Services.AddControllersWithViews().AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();builder.Services.AddSwaggerGen();builder.Services.AddDbContext<ApplicationDbContext>(context => context.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));builder.Services.AddAutoMapper(typeof(AutoMapperProfile));builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();builder.Services.AddScoped<IStadiumRepository, StadiumRepository>();builder.Services.AddScoped<IEnclosureRepository,EnclosureRepository>();builder.Services.AddScoped<ISeatRepository,SeatRepository>();builder.Services.AddScoped<IMatchRepsitory,MatchRepository>();builder.Services.AddScoped<ITicketRepository,TicketRepository>();var app = builder.Build();// Configure the HTTP request pipeline.if (app.Environment.IsDevelopment()){    app.UseSwagger();    app.UseSwaggerUI();}app.UseHttpsRedirection();app.UseAuthorization();app.MapControllers();app.Run();