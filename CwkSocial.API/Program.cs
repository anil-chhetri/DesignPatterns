using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//builder.Services.AddApiVersioning(setup =>
//{
//    setup.DefaultApiVersion = new ApiVersion(1, 0);
//    setup.AssumeDefaultVersionWhenUnspecified = true;
//    setup.ReportApiVersions = true;
//    setup.ApiVersionReader = new UrlSegmentApiVersionReader();
//});

//builder.Services.AddVersionedApiExplorer(setup =>
//{
//    setup.GroupNameFormat = "'v'VVV";
//    setup.SubstituteApiVersionInUrl = true;
//});
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
