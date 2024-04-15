

using Newtonsoft.Json.Serialization;
using WebAPI;

Startups.Configure();

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.



builder.Services.AddControllers();



builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();



builder.Services.AddControllers().AddNewtonsoftJson(options =>

options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore).AddNewtonsoftJson(

    options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());


var app = builder.Build();



app.UseCors(c => c.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();