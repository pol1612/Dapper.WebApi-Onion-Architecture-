using Dapper.WebApi.Extensions;
using Swashbuckle.AspNetCore;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers();
builder.Services.AddInfrastructure();
builder.Services.AddSwaggerGen
    (
    c => c.SwaggerDoc("v1", new OpenApiInfo
        {
            Version = "v1",
            Title = "Dapper - WebApi",
        })
    );
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{id?}");

app.UseSwagger();
app.UseSwaggerUI
    (
    c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Dapper.WebApi")
    );

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
